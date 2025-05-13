using DAL.Model;
using DAL.Repository;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StockServiceBLL : IStockServiceBLL
    {
        private readonly StockRepositoryDAL _stockRepositoryDAL = new StockRepositoryDAL();
        private readonly ProductRepositoryDAL _productRepositoryDAL = new ProductRepositoryDAL();

        private readonly CategoryRepositoryDAL _categoryDAL = new CategoryRepositoryDAL();


        //Lấy danh sách các đơn nhập kho
        public List<StockDTO> GetAllStocks()
        {
            return _stockRepositoryDAL.GetAllStocks()
                .Select(p => new StockDTO
                {
                    stockID = p.StockID,
                    productID = p.ProductID,
                    cost = p.Cost,
                    stockQuantity = p.StockQuantity,
                    importDate = p.ImportDate,
                    expiryDate = p.ExpiryDate

                }).ToList();
        }

        public List<StockDTO> GetStocksToOrder()
        {
            // Bước 1: Lấy toàn bộ dữ liệu Stock
            var stocks = _stockRepositoryDAL.GetAllStocks();

            // Bước 2: Tính tổng StockQuantity theo ProductID (lấy tất cả sản phẩm)
            var totalQuantities = stocks
                .GroupBy(s => s.ProductID)
                .Select(g => new
                {
                    ProductID = g.Key,
                    TotalQuantity = g.Sum(s => s.StockQuantity)
                })
                .ToList();

            // Bước 3: Lấy danh sách ProductID từ tất cả sản phẩm
            var productIds = totalQuantities.Select(t => t.ProductID).ToList();

            // Bước 4: Lấy dữ liệu chi tiết từ Products và Categories
            var products = _productRepositoryDAL.GetProductsByStockIds(stocks.Where(s => productIds.Contains(s.ProductID)).ToList());
            var categories = _categoryDAL.GetCategoriesByProductIds(products);

            // Bước 5: Ánh xạ sang StockDTO
            var stocksToOrder = stocks
                .Where(s => productIds.Contains(s.ProductID))
                .Select(s =>
                {
                    var product = products.FirstOrDefault(p => p.ProductID == s.ProductID);
                    var category = categories.FirstOrDefault(c => c.CategoryID == product?.CategoryID);
                    return new StockDTO
                    {
                        productID = s.ProductID,
                        productName = product?.ProductName,
                        categoryID = product?.CategoryID ?? 0,
                        categoryName = category?.CategoryName,
                        totalQuantity = totalQuantities.FirstOrDefault(t => t.ProductID == s.ProductID).TotalQuantity
                    };
                })
                .GroupBy(s => s.productID)
                .Select(g => g.First())
                .OrderBy(s => s.totalQuantity) //xếp theo tổng số lượng
                .ThenBy(s => s.categoryID) //xếp theo categoryID
                .ThenBy(s => s.productID) //xếp theo productID
                .ToList();

            return stocksToOrder;
        }


        public bool AddStock(StockDTO stock)
        {
            var newStock = new Stock
            {
                ProductID = stock.productID,
                Cost = stock.cost,
                StockQuantity = stock.stockQuantity,
                ImportDate = stock.importDate,
                ExpiryDate = stock.expiryDate
            };
            _stockRepositoryDAL.AddStock(newStock);
            return true;
        }

        //nghiệm vụ này là để kiểm tra tính hợp lệ của thông tin nhập kho
        public void Validate(StockDTO stock)
        {
            if (stock.expiryDate <= stock.importDate)
            {
                throw new ArgumentException("Expiry date must be after import date.");
            }
        }

        public bool UpdateStock(StockDTO stock)
        {
            var existingStock = _stockRepositoryDAL.GetAllStocks().FirstOrDefault(s => s.StockID == stock.stockID);
            if (existingStock == null)
            {
                return false;
            }
            existingStock.ProductID = stock.productID;
            existingStock.Cost = stock.cost;
            existingStock.StockQuantity = stock.stockQuantity;
            existingStock.ImportDate = stock.importDate;
            existingStock.ExpiryDate = stock.expiryDate;
            return _stockRepositoryDAL.UpdateStock(existingStock);
        }

        public StockDTO GetClosestStockByProductID(int productID)
        {
            var stock = _stockRepositoryDAL.GetClosestStockByProductID(productID);
            if (stock == null)
            {
                return null;
            }
            return new StockDTO
            {
                stockID = stock.StockID,
                productID = stock.ProductID,
                cost = stock.Cost,
                stockQuantity = stock.StockQuantity,
                importDate = stock.ImportDate,
                expiryDate = stock.ExpiryDate
            };
        }
    }

}
