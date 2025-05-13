using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class StockRepositoryDAL : IStockRepositoryDAL
    {

        private readonly StoreContext _context = new StoreContext();

        //Danh sách các đơn nhập kho
        public List<Stock> GetAllStocks()
        {
            return _context.Stocks.ToList();
        }

        //Gộp nhóm theo ProductID và tính tổng StockQuantity
        public Dictionary<int?, int> GetTotalQuantityByProductId()
        {
            return _context.Stocks
                .GroupBy(s => s.ProductID)
                .ToDictionary(g => g.Key, g => g.Sum(s => s.StockQuantity));
        }

        public Stock AddStock(Stock stock)
        {
            _context.Stocks.Add(stock);
            _context.SaveChanges();
            return stock;
        }

        // Lấy stock gần đát nhất cho 1 sản phẩm
        public Stock GetClosestStockByProductID(int productID)
        {
            return _context.Stocks.Select(s => s)
                .Where(s => s.ProductID == productID && s.StockQuantity > 0)
                .OrderBy(s => s.ExpiryDate)
                .FirstOrDefault();
        }

        public bool UpdateStock(Stock stock) {
            var existingStock = _context.Stocks.Find(stock.StockID);

            if (existingStock == null)
            {
                return false;
            }

            try
            {
                _context.Entry(existingStock).CurrentValues.SetValues(stock);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc hiện thông báo
                Console.WriteLine("Error when updating stock: " + ex.Message);
                return false;
            }

        }
    }
}

