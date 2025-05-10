using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IStockRepositoryDAL
    {
        Stock AddStock(Stock stock);
        List<Stock> GetAllStocks();
        Dictionary<int?, int> GetTotalQuantityByProductId();
    }
}