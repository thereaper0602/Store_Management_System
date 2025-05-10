using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IStockServiceBLL
    {
         
        bool AddStock(StockDTO stock);
        List<StockDTO> GetAllStocks();
        List<StockDTO> GetStocksToOrder();

        void Validate(StockDTO stock);
    }
}