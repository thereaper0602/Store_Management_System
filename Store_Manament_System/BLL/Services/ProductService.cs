using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO.DTO;

namespace BLL.Services
{
    public class ProductService
    {
        private readonly StoreContext _context = new StoreContext();
        private readonly ImageServiceBLL _imageService = new ImageServiceBLL();
        public List<ProductDTO> GetAllProducts(String kw)
        {
            if(kw == null)
            {
                kw = "";
            }
            return _context.Products
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
            var product = _context.Products.FirstOrDefault(p => p.ProductID == id);
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
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Thêm ảnh mới và lấy ID
                    var image = new Image
                    {
                        ImageName = imageDTO.imageName,
                        ImagePath = imageDTO.imagePath,
                        UploadDate = DateTime.Now
                    };
                    _context.Images.Add(image);
                    _context.SaveChanges(); // Lưu để có được ImageID
                    int newImageId = image.ImageID;

                    // Gán ImageID cho sản phẩm
                    var product = new Product
                    {
                        ProductName = productDTO.name,
                        CategoryID = productDTO.categoryID,
                        StockQuantity = productDTO.stockQuantity,
                        Price = productDTO.price,
                        Description = productDTO.description,
                        ExpiryDate = productDTO.expiryDate,
                        ImageID = newImageId,
                        Barcode = productDTO.barcode,
                    };

                    _context.Products.Add(product);
                    _context.SaveChanges();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Lỗi khi thêm sản phẩm: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateProduct(ProductDTO productDTO)
        {
            try
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductID == productDTO.id);
                if (product == null)
                {
                    return false;
                }
                product.ProductName = productDTO.name;
                product.CategoryID = productDTO.categoryID;
                product.StockQuantity = productDTO.stockQuantity;
                product.Price = productDTO.price;
                product.Description = productDTO.description;
                product.ExpiryDate = productDTO.expiryDate;
                product.ImageID = productDTO.imageID;
                product.Barcode = productDTO.barcode;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc hiện thông báo
                Console.WriteLine("Error when updating product: " + ex.Message);
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductID == id);
                if (product == null)
                {
                    return false;
                }
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc hiện thông báo
                Console.WriteLine("Error when deleting product: " + ex.Message);
                return false;
            }
        }

    }
}
