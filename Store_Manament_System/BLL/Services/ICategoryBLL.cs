using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface ICategoryBLL
    {
        void AddCategory(CategoryDTO category, ImageDTO imageDTO = null);
        void DeleteCategory(int categoryID);
        List<CategoryDTO> GetAllCategories();
        List<CategoryDTO> SearchCategories(string keyword);
        void UpdateCategory(CategoryDTO category);
    }
}