using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductRepositoryDAL : IProductRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();
        //public ProductRepositoryDAL(StoreContext context)
        //{
        //    _context = context ?? throw new ArgumentNullException(nameof(context));
        //}
        public List<Product> GetAllProducts(String kw)
        {
            return _context.Products.ToList();
        }

        public List<Product> GetAvailableProducts(String kw)
        {
            var res = (from p in _context.Products
                       join s in _context.Stocks on p.ProductID equals s.ProductID
                       where s.StockQuantity > 0
                       select p).ToList();
            return res;
        }

        public Product GetProductById(int id)
        {
            //return _context.Products.FirstOrDefault(p => p.ProductID == id);
            return _context.Products.Find(id);
        }

        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                var existing_product = _context.Products.Find(product.ProductID);
                if (product == null)
                {
                    return false;
                }
                _context.Entry(existing_product).CurrentValues.SetValues(product);
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
                var product = _context.Products.Find(id);
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

        //Phần này của StockRepositoryDAL
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return _context.Products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public List<Product> GetProductsByStockIds(List<Stock> stocks)
        {
            var productIds = stocks.Select(s => s.ProductID).Distinct().ToList();
            return _context.Products
                .Where(p => productIds.Contains(p.ProductID))
                .ToList();
        }

        public Promotion GetNearestPromotionByProductId(int productId)
        {
            var promotion = (from p in _context.Products
                             join pr in _context.ProductPromotions on p.ProductID equals pr.ProductID
                             join pro in _context.Promotions on pr.PromotionID equals pro.PromotionID
                             where p.ProductID == productId &&
                                   pro.StartDate <= DateTime.Now &&
                                   pro.EndDate >= DateTime.Now
                             select pro).FirstOrDefault();
            return promotion;
        }

        public Product GetProductByProductCode(string productCode)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductCode == productCode);
            return product;
        }
    }
}
