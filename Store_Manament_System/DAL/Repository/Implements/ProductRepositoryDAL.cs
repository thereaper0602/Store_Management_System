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
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductID == id);
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
                //existing_product.ProductName = product.ProductName;
                //existing_product.CategoryID = product.CategoryID;
                //existing_product.Price = product.Price;
                //existing_product.Description = product.Description;
                //existing_product.ImageID = product.ImageID;
                //existing_product.ProductCode = product.ProductCode;
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
    }
}
