using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.IO;
using DTO.DTO;
using BLL.Services;

namespace GUI
{
    public partial class CategoryManagement : UserControl
    {
        private readonly CategoryBLL _categoryBLL;
        private string _selectedImagePath; // Lưu đường dẫn ảnh khi chọn
        public CategoryManagement()
        {

            InitializeComponent();
            if (!DesignMode)
            {
                _categoryBLL = new CategoryBLL(); // Khởi tạo categoryBLL trong constructor
            }
        }
    
        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                detail_cate.AutoGenerateColumns = false;
                detail_cate.DataSource = _categoryBLL.GetAllCategories();
                pic_cate.Image = null;
                detail_cate.Columns["ID_cate"].ReadOnly = true;
                detail_cate.Columns["ImageID_cate"].ReadOnly = true;
            }
        }

        // Tải danh sách Category vào DataGridView
        private void RefreshDataGridView()
        {
            try
            {
                detail_cate.DataSource = null;
                detail_cate.DataSource = _categoryBLL.GetAllCategories();

                detail_cate.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Refresh error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void search_category_Click(object sender, EventArgs e)
        {
            string keyword = searchbox_cate.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                detail_cate.DataSource = _categoryBLL.SearchCategories(keyword);
            }
            else
            {
                RefreshDataGridView(); // Nếu không có từ khóa, tải lại toàn bộ danh sách
            }
        }


        private void addpic_cate_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Kiểm tra kích thước file (giới hạn 5MB)
                        FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                        long fileSizeInBytes = fileInfo.Length;
                        long fileSizeInMB = fileSizeInBytes / (1024 * 1024);

                        if (fileSizeInMB > 5)
                        {
                            MessageBox.Show("The image is too large! Please select an image smaller than 5MB.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }

                        // Hiển thị ảnh lên PictureBox
                        pic_cate.Image?.Dispose();
                        pic_cate.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        pic_cate.Image?.Dispose();
                        pic_cate.Image = null;
                    }
                }
            }
 
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(tb2_cate.Text))
            {
                MessageBox.Show("Please enter the Category Name!", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // Kiểm tra xem đã chọn ảnh chưa
            if (pic_cate.Image == null)
            {
                MessageBox.Show("Please select an image for the category!", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // Tạo thư mục Images\Categories trong thư mục dự án
                string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Images\Categories");
                if (!Directory.Exists(imageFolder))
                {
                    Directory.CreateDirectory(imageFolder);
                }

                // Tạo tên file duy nhất với đuôi .jpg
                string imageName = Guid.NewGuid().ToString() + ".jpg";
                string imagePath = Path.Combine(imageFolder, imageName);

                // Lưu ảnh từ PictureBox dưới dạng .jpg
                pic_cate.Image.Save(imagePath);  // Bỏ phần encoderParameters để sát với bài Product

                // Tạo ImageDTO
                ImageDTO imageDTO = new ImageDTO
                {
                    imageName = imageName,
                    imagePath = imagePath
                };

                // Tạo CategoryDTO và thêm vào danh sách
                var newCategory = new CategoryDTO
                {
                    CategoryName = tb2_cate.Text,
                    ImageID = null
                };

                // Gọi BLL để lưu category và ảnh
                _categoryBLL.AddCategory(newCategory, imageDTO);  // Sửa tham số thành ImageDTO

                // Làm mới giao diện
                RefreshDataGridView();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding category: {ex.Message}\nDetails: {ex.StackTrace}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
       
        private void ClearInputs()
        {

            tb2_cate.Text = string.Empty;
            pic_cate.Image?.Dispose();
            pic_cate.Image = null;
        }

        private void save_cate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem DataGridView có chứa các cột cần thiết không
            if (!detail_cate.Columns.Contains("ID_cate") || !detail_cate.Columns.Contains("category_cate"))
            {
                MessageBox.Show("Required columns (ID_cate, category_cate) not found in DataGridView!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool coThayDoi = false;

            try
            {
                foreach (DataGridViewRow row in detail_cate.Rows)
                {
                    // Bỏ qua hàng mới (nếu có)
                    if (row.IsNewRow) continue;

                    // Kiểm tra tính hợp lệ của CategoryID
                    if (row.Cells["ID_cate"].Value == null)
                    {
                        MessageBox.Show("Invalid category ID in some rows!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(row.Cells["ID_cate"].Value.ToString(), out int categoryID))
                    {
                        MessageBox.Show("Category ID must be an integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    // Lấy giá trị CategoryName hiện tại từ DataGridView
                    string tenDanhMucMoi = row.Cells["category_cate"].Value?.ToString() ?? string.Empty;

                    // Lấy danh mục gốc từ cơ sở dữ liệu để so sánh
                    var danhMucGoc = _categoryBLL.GetAllCategories()
                        .FirstOrDefault(c => c.CategoryID == categoryID);

                    if (danhMucGoc == null)
                    {
                        MessageBox.Show($"Category with ID {categoryID} not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    // Kiểm tra xem CategoryName có thực sự thay đổi không
                    if (danhMucGoc.CategoryName != tenDanhMucMoi)
                    {
                        var danhMuc = new CategoryDTO
                        {
                            CategoryID = categoryID,
                            CategoryName = tenDanhMucMoi,
                            ImageID = danhMucGoc.ImageID // Giữ nguyên ImageID ban đầu
                        };

                        // Cập nhật danh mục trong cơ sở dữ liệu
                        _categoryBLL.UpdateCategory(danhMuc);
                        coThayDoi = true;
                    }
                }

                // Làm mới DataGridView chỉ một lần sau khi cập nhật xong
                if (coThayDoi)
                {
                    RefreshDataGridView();
                    MessageBox.Show("Data saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No data was updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}\nError details: {ex.StackTrace}",
      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        }

        private void delete_cate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem DataGridView có đủ cột không
            if (detail_cate.Columns.Count < 2) // Cần ít nhất 2 cột: checkbox (index 0) và ID (index 1)
            {
                MessageBox.Show("DataGridView does not contain enough columns to perform deletion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Kiểm tra xem có hàng nào được chọn không (checkbox ở index 0)
            bool hasSelectedRows = detail_cate.Rows.Cast<DataGridViewRow>()
                .Any(row => !row.IsNewRow && row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value));

            if (!hasSelectedRows)
            {
                MessageBox.Show("Please select at least one row to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected categories?", 
                "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (result == DialogResult.OK)
            {
                try
                {
                    // Lặp qua các hàng trong DataGridView
                    foreach (DataGridViewRow row in detail_cate.Rows)
                    {
                        if (row.IsNewRow) continue; // Bỏ qua hàng mới

                        // Kiểm tra nếu checkbox được chọn (cột index 0)
                        if (row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value))
                        {
                            // Lấy CategoryID từ cột index 1
                            if (row.Cells[1].Value == null)
                            {
                                MessageBox.Show("Invalid category ID in one or more rows!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }

                            int categoryID;
                            if (!int.TryParse(row.Cells[1].Value.ToString(), out categoryID))
                            {
                                MessageBox.Show("Category ID must be an integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }

                            _categoryBLL.DeleteCategory(categoryID); // Gọi phương thức xóa
                        }
                    }

                    // Làm mới DataGridView sau khi xóa
                    RefreshDataGridView();
                    MessageBox.Show("Category deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchbox_cate_TextChange(object sender, EventArgs e)
        {
            try
            {
                string keyword = searchbox_cate.Text.Trim();
                detail_cate.DataSource = null;
                detail_cate.DataSource = string.IsNullOrEmpty(keyword)
                    ? _categoryBLL.GetAllCategories()
                    : _categoryBLL.SearchCategories(keyword); // Gọi SearchCategories đã sửa
                detail_cate.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
