using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Category_DAL : ICategory_DAL
    { // Khai báo context để kết nối và làm việc với database thông qua Entity Framework
        private readonly StoreContext _context = new StoreContext();

        // Tạo context khi một đối tượng Category_DAL được tạo
        public Category_DAL()
        {
            _context = new StoreContext();
        }
        // Lấy toàn bộ danh mục trong bảng Categories
        public List<Category> GetAllCategories()
        {
            // Truy vấn toàn bộ dữ liệu từ bảng Categories
            return _context.Categories.ToList();
        }

        // Tìm kiếm danh mục theo từ khóa 
        public List<Category> SearchCategories(string keyword)
        {
            // Nếu không nhập gì, thì trả về toàn bộ danh mục
            if (string.IsNullOrEmpty(keyword))
                return GetAllCategories();
            // Chuyển keyword về chữ thường để tìm không phân biệt hoa thường
            keyword = keyword.ToLower();
            // Tìm các bản ghi có CategoryID, CategoryName, hoặc ImageID chứa từ khóa
            return _context.Categories
                .Where(c => c.CategoryID.ToString().ToLower().Contains(keyword) ||
                            c.CategoryName.ToLower().Contains(keyword) ||
                            (c.ImageID.HasValue && c.ImageID.ToString().ToLower().Contains(keyword)))
                .ToList(); // Trả kết quả dạng List

        }
        // Thêm một danh mục mới vào cơ sở dữ liệu
        public void AddCategory(Category category)
        {
            // Thêm entity vào context
            _context.Categories.Add(category);
            // Lưu thay đổi vào DB
            _context.SaveChanges();
        }

        // Cập nhật thông tin một danh mục trong cơ sở dữ liệu
        public void UpdateCategory(Category category)
        {
            // Tìm danh mục cũ theo ID
            var existing = _context.Categories.FirstOrDefault(c => c.CategoryID == category.CategoryID);
            if (existing != null)
            {
                // Cập nhật thông tin mới
                existing.CategoryName = category.CategoryName;
                existing.ImageID = category.ImageID;
                // Lưu vào DB
                _context.SaveChanges();
            }
        }
        // Xóa danh mục theo ID
        public void DeleteCategory(int id)
        {
            // Tìm danh mục cần xóa
            var category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (category != null)
            {
                // Xóa khỏi context
                _context.Categories.Remove(category);
                // Lưu thay đổi
                _context.SaveChanges();
            }
        }
    }
}
