using DAL.Model;
using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IStockServiceBLL
    {
         
        void AddStock(StockDTO stock);
        List<CategoryDTO> GetAllCategories();
        List<StockDTO> GetAllStocks();
        List<ProductDTO> GetProductsByCategoryId(int categoryId);
        List<StockDTO> GetStocksToOrder();
        void Validate(StockDTO stock);
        bool UpdateStock(StockDTO stock);
        StockDTO GetClosestStockByProductID(int productID);
    }
}