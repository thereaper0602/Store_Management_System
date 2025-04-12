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
        public List<ProductDTO> GetAllProducts()
        {
            return _context.Products.Select(p =>
            new ProductDTO
            {
                id = p.ProductID,
                name = p.ProductName,
                categoryID = p.CategoryID ?? 1,
                stockQuantity = p.StockQuantity,
                price = p.Price,
                expiryDate = p.ExpiryDate ?? DateTime.MinValue
            }).ToList();
        }
        

    }
}
