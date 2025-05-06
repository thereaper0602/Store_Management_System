using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IProductRepositoryDAL
    {
        Product AddProduct(Product product);
        bool DeleteProduct(int id);
        List<Product> GetAllProducts(string kw);
        List<Product> GetAvailableProducts(string kw);
        Product GetProductById(int id);
        bool UpdateProduct(Product product);

        //Phần này của stock repository
        List<Product> GetProductsByCategoryId(int categoryId);
        List<Product> GetProductsByStockIds(List<Stock> stocks);


    }
}