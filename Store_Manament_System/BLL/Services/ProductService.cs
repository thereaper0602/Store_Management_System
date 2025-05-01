using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO.DTO;
using DAL.Repository;

namespace BLL.Services
{
    public class ProductService
    {
        private readonly ProductRepositoryDAL productRepositoryDAL = new ProductRepositoryDAL();
        private readonly ImageRepositoryDAL imageRepositoryDAL = new ImageRepositoryDAL();
        private readonly StoreContext _context = new StoreContext();
        public List<ProductDTO> GetAllProducts(String kw)
        {
            if(kw == null)
            {
                kw = "";
            }
            return productRepositoryDAL.GetAllProducts(kw)
                .Where(p => p.ProductName.Contains(kw) || p.Description.Contains(kw))
                .Select(p => new ProductDTO
                {
                    id = p.ProductID,
                    name = p.ProductName,
                    categoryID = p.CategoryID ?? 1,
                    stockQuantity = p.StockQuantity,
                    price = p.Price,
                    description = p.Description,
                    expiryDate = p.ExpiryDate ?? DateTime.MinValue,
                    imageID = p.ImageID ?? 1,
                    barcode = p.Barcode
                }).ToList();
        }

        public ProductDTO GetProductById(int id)
        {
            var product = productRepositoryDAL.GetProductById(id);
            if (product == null)
            {
                return null;
            }
            return new ProductDTO
            {
                id = product.ProductID,
                name = product.ProductName,
                categoryID = product.CategoryID ?? 1,
                stockQuantity = product.StockQuantity,
                price = product.Price,
                description = product.Description,
                expiryDate = product.ExpiryDate ?? DateTime.MinValue,
                imageID = product.ImageID ?? 1,
                barcode = product.Barcode
            };
        }

        public bool AddProduct(ProductDTO productDTO, ImageDTO imageDTO)
        {
            if(productDTO == null || imageDTO == null)
            {
                return false;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var image = new Image
                    {
                        ImageName = imageDTO.imageName,
                        ImagePath = imageDTO.imagePath,
                        UploadDate = DateTime.Now
                    };
                    var savedImage = imageRepositoryDAL.AddImage(image);

                    var product = new Product
                    {
                        ProductName = productDTO.name,
                        CategoryID = productDTO.categoryID,
                        StockQuantity = productDTO.stockQuantity,
                        Price = productDTO.price,
                        Description = productDTO.description,
                        ExpiryDate = productDTO.expiryDate,
                        ImageID = savedImage.ImageID,
                        Barcode = productDTO.barcode
                    };

                    productRepositoryDAL.AddProduct(product);
                    transaction.Commit();
                    return true;
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Lỗi khi thêm sản phẩm: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateProduct(ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return false;
            }

            try
            {
                var product = new Product
                {
                    ProductID = productDTO.id,
                    ProductName = productDTO.name,
                    CategoryID = productDTO.categoryID,
                    StockQuantity = productDTO.stockQuantity,
                    Price = productDTO.price,
                    Description = productDTO.description,
                    ExpiryDate = productDTO.expiryDate,
                    ImageID = productDTO.imageID,
                    Barcode = productDTO.barcode
                };
                return productRepositoryDAL.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật sản phẩm: " + ex.Message);
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            return productRepositoryDAL.DeleteProduct(id);
        }

        public List<ProductDTO> GetAvailableProducts(String kw)
        {
            if(kw == null)
            {
                kw = "";
            }
            var products = productRepositoryDAL.GetAvailableProducts(kw);
            return products
                .Where(p => (p.ProductName.Contains(kw) || p.Description.Contains(kw)) && p.StockQuantity > 0)
                .Select(p => new ProductDTO
                {
                    id = p.ProductID,
                    name = p.ProductName,
                    categoryID = p.CategoryID ?? 1,
                    stockQuantity = p.StockQuantity,
                    price = p.Price,
                    description = p.Description,
                    expiryDate = p.ExpiryDate ?? DateTime.MinValue,
                    imageID = p.ImageID ?? 1,
                    barcode = p.Barcode
                }).ToList();
        }

    }
}
