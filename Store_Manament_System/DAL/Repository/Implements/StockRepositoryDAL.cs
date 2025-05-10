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
    }
}

