using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Model;
using DAL.Repository;
using DTO.DTO; 

namespace BLL.Services
{
    public class CategoryBLL
    {
        // Khai báo đối tượng để tương tác với dữ liệu danh mục
        private readonly Category_DAL _categoryDAL;
        // Khai báo đối tượng để tương tác với dữ liệu hình ảnh
        private readonly Image_DAL _imageDAL;


        // Hàm khởi tạo khi tạo đối tượng CategoryBLL
        public CategoryBLL() 
        {
            // Khởi tạo đối tượng DAL để làm việc với danh mục
            _categoryDAL = new Category_DAL();
            // Khởi tạo đối tượng DAL để làm việc với hình ảnh
            _imageDAL = new Image_DAL();
        }
        // Lấy tất cả danh mục từ CSDL và chuyển sang dạng DTO để dùng cho GUI
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
        /*SEARCH*/
        // Tìm kiếm danh mục theo từ khóa
        public List<CategoryDTO> SearchCategories(string keyword)
        {
            // Gọi hàm search trong DAL và ánh xạ kết quả sang DTO
            return _categoryDAL.SearchCategories(keyword)
                .Select(c => new CategoryDTO
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    ImageID = c.ImageID
                })
                .ToList();
        }
        /*ADD*/
        //Thêm mới một danh mục
        public void AddCategory(CategoryDTO category, ImageDTO imageDTO = null)  
        {
            try
            {
                // Kiểm tra đầu vào: nếu category null thì báo lỗi
                if (category == null)
                {
                    throw new ArgumentNullException(nameof(category), "Category information cannot be left blank.");
                }
                // Kiểm tra tên danh mục có bị bỏ trống không
                if (string.IsNullOrEmpty(category.CategoryName))
                {
                    throw new ArgumentException("Category name cannot be left blank.");
                }
                // Khởi tạo ID ảnh là null (TH không có ảnh)
                int? imageID = null; 
                // Nếu có ảnh, thêm ảnh vào CSDL trước
                if (imageDTO != null)
                {
                    // Gọi DAL để thêm ảnh và lấy ID ảnh mới được tạo
                    imageID = _imageDAL.AddImage(imageDTO.imagePath, imageDTO.imageName);
                }
                // Tạo đối tượng danh mục để lưu vào DB
                var newCategory = new Categories
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    ImageID = imageID
                };
                // Gọi DAL để thêm danh mục
                _categoryDAL.AddCategory(newCategory);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when adding category: {ex.Message}", ex);
            }
        }

        /*UPDATE*/
        //Cập nhật thông tin danh mục
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
        /*DELETE*/
        //Xóa danh mục
        public void DeleteCategory(int categoryID)
        {
            _categoryDAL.DeleteCategory(categoryID);
        }
    }
}
 