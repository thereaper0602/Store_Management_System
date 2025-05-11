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
    public class ProductService : IProductService
    {
        private readonly IProductRepositoryDAL productRepositoryDAL = new ProductRepositoryDAL();
        private readonly ImageRepositoryDAL imageRepositoryDAL = new ImageRepositoryDAL();
        private readonly StoreContext _context = new StoreContext();

        //public ProductService(IProductRepositoryDAL productRepositoryDAL)
        //{
        //    this.productRepositoryDAL = productRepositoryDAL ?? throw new ArgumentNullException(nameof(productRepositoryDAL));
        //}



        public List<ProductDTO> GetAllProducts(String kw)
        {
            if (kw == null)
            {
                kw = "";
            }
            return productRepositoryDAL.GetAllProducts(kw)
                .Where(p => p.ProductName.Contains(kw) || p.Description.Contains(kw))
                .Select(p => new ProductDTO
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    CategoryID = p.CategoryID,
                    Price = p.Price,
                    Description = p.Description,
                    ImageID = p.ImageID ?? 1,
                    ProductCode = p.ProductCode
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
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                CategoryID = product.CategoryID,
                Price = product.Price,
                Description = product.Description,
                ImageID = product.ImageID ?? 1,
                ProductCode = product.ProductCode
            };
        }

        // Hàm tạo mã sản phẩm
        private string GenerateProductCode(string productName)
        {
            // Lấy 3 ký tự đầu của tên sản phẩm (viết hoa)
            string prefix = productName.Length >= 3 ?
                           productName.Substring(0, 3).ToUpper() :
                           productName.ToUpper().PadRight(3, 'X');

            // Thêm timestamp (để đảm bảo duy nhất)
            string timestamp = DateTime.Now.ToString("yyMMddHHmmss");

            // Thêm 4 số ngẫu nhiên
            Random rnd = new Random();
            string randomPart = rnd.Next(1000, 9999).ToString();

            return $"{prefix}-{timestamp}-{randomPart}";
        }

        public bool AddProduct(ProductDTO productDTO, ImageDTO imageDTO)
        {
            if (productDTO == null || imageDTO == null)
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
                    if (savedImage == null)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    string productCode = GenerateProductCode(productDTO.ProductName);

                    var product = new Product
                    {
                        ProductName = productDTO.ProductName,
                        CategoryID = productDTO.CategoryID,
                        Price = productDTO.Price,
                        Description = productDTO.Description,
                        ImageID = savedImage.ImageID,
                        ProductCode = productCode
                    };

                    productRepositoryDAL.AddProduct(product);
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
            if (productDTO == null)
            {
                return false;
            }

            try
            {
                var product = new Product
                {
                    ProductID = productDTO.ProductID,
                    ProductName = productDTO.ProductName,
                    CategoryID = productDTO.CategoryID,
                    Price = productDTO.Price,
                    Description = productDTO.Description,
                    ImageID = productDTO.ImageID,
                    ProductCode = productDTO.ProductCode
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

        public List<ProductDTO> GetAvailableProducts(String kw, int categoryId)
        {
            if (kw == null)
            {
                kw = "";
            }

            var products = productRepositoryDAL.GetAvailableProducts(kw);

            return products
                .Where(p => (p.ProductName.Contains(kw) || p.Description.Contains(kw)))
                .Where(p => categoryId == -1 || p.CategoryID == categoryId)  // Thêm điều kiện lọc danh mục
                .Select(p => new ProductDTO
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    CategoryID = p.CategoryID ?? 1,
                    Price = p.Price,
                    Description = p.Description,
                    ImageID = p.ImageID ?? 1,
                    ProductCode = p.ProductCode
                })
                .ToList();
        }

        public PromotionDTO GetNearestPromotionByProductId(int productId)
        {
            var promotion = productRepositoryDAL.GetNearestPromotionByProductId(productId);
            if (promotion == null)
            {
                return null;
            }
            return new PromotionDTO
            {
                promotionID = promotion.PromotionID,
                promotionName = promotion.PromotionName,
                discountRate = promotion.DiscountRate,
                startDate = promotion.StartDate,
                endDate = promotion.EndDate
            };
        }

        public ProductDTO GetProductByProductCode(string productCode)
        {
            var product = productRepositoryDAL.GetProductByProductCode(productCode);
            if (product == null)
            {
                return null;
            }
            return new ProductDTO
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                CategoryID = product.CategoryID,
                Price = product.Price,
                Description = product.Description,
                ImageID = product.ImageID ?? 1,
                ProductCode = product.ProductCode
            };
        }
    }
}
