using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface ICategory_DAL
    {
        void AddCategory(Category category);
        void DeleteCategory(int id);
        List<Category> GetAllCategories();
        List<Category> SearchCategories(string keyword);
        void UpdateCategory(Category category);
    }
}