using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface ICategoryRepositoryDAL
    {
        void AddCategory(Category category);
        void DeleteCategory(int id);
        List<Category> GetAllCategories();
        List<Category> SearchCategories(string keyword);
        void UpdateCategory(Category category);

        //Phần này của StockRepositoryDAL
        List<Category> GetCategoriesByProductIds(List<Product> products);
    }
}