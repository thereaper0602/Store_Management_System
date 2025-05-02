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
    public class CategoryBLL
    {
        private readonly Category_DAL _categoryDAL;
        private readonly Image_DAL _imageDAL;

        public CategoryBLL()
        {
            _categoryDAL = new Category_DAL();
            _imageDAL = new Image_DAL();
        }

        public List<CategoryDTO> GetAllCategories()
        {
            return _categoryDAL.GetAllCategories()
                .Select(c => new CategoryDTO
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    ImageID = c.ImageID
                })
                .ToList();
        }

        public List<CategoryDTO> SearchCategories(string keyword)
        {
            return _categoryDAL.SearchCategories(keyword)
                .Select(c => new CategoryDTO
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    ImageID = c.ImageID
                })
                .ToList();
        }

        public void AddCategory(CategoryDTO category, string imagePath = null, string imageName = null)
        {
            int? imageID = null;
            if (!string.IsNullOrEmpty(imagePath) && !string.IsNullOrEmpty(imageName))
            {
                imageID = _imageDAL.AddImage(imagePath, imageName);
            }

            var newCategory = new Categories
            {
                CategoryID = category.CategoryID,
                CategoryName = category.CategoryName,
                ImageID = imageID
            };

            _categoryDAL.AddCategory(newCategory);
        }

        public void UpdateCategory(CategoryDTO category)
        {
            var updatedCategory = new Categories
            {
                CategoryID = category.CategoryID,
                CategoryName = category.CategoryName,
                ImageID = category.ImageID
            };

            _categoryDAL.UpdateCategory(updatedCategory);
        }

        public void DeleteCategory(int categoryID)
        {
            _categoryDAL.DeleteCategory(categoryID);
        }
    }
}
