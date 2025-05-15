using BLL.Services;
using DTO.DTO;
using GUI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace GUI.UI_ADMIN
{
    public partial class StockManagement : UserControl, IRefreshable
    {

        //Khai báo biến
        private readonly IStockServiceBLL _stockService;
        public StockManagement()
        {
            InitializeComponent();
            //khởi tạo biến
            _stockService = new StockServiceBLL();

        }

        private void LoadData()
        {
            // Tải dữ liệu từ cơ sở dữ liệu vào DataGridView
            RefreshStockTab();
            RefreshWareHouseTab();
            // Tải danh sách CategoryName vào ComboBox
            LoadCategoryName();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            importDate.Value = DateTime.Now;
            expiryDate.Value = DateTime.Now.AddDays(30); // Thay đổi số ngày theo yêu cầu
        }

        private void tabCtrolStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTabData();
        }

        private void RefreshTabData()
        {
            switch (tabCtrolStock.SelectedIndex)
            {
                // Tab Information
                case 0:
                    RefreshStockTab();
                    break;
                // Tab WorkShift
                case 1:
                    RefreshWareHouseTab();
                    break;

            }
        }

        #region Tab Stock
        private void RefreshStockTab()
        {
            try
            {
                var stock = _stockService.GetStocksToOrder();
                viewStockToOrder.AutoGenerateColumns = false;
                viewStockToOrder.DataSource = null;
                viewStockToOrder.DataSource = stock;
                viewStockToOrder.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when refreshing stock to order list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Lấy danh sách CategoryName
        private void LoadCategoryName()
        {
            try
            {
                // Tải danh sách CategoryName từ cơ sở dữ liệu
                ICategoryBLL category = new CategoryBLL();
                List<CategoryDTO> categoryName = category.GetAllCategories();
                if (categoryName != null && categoryName.Count > 0)
                {
                    cbCategoryName.DataSource = categoryName;
                    cbCategoryName.DisplayMember = "categoryName";
                    cbCategoryName.ValueMember = "categoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when downloading the shift list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lấy danh sách ProductName theo CategoryID
        private void cbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoryName.SelectedItem != null)
            {
                var category = (CategoryDTO)cbCategoryName.SelectedItem;
                LoadProductsByCategory(category.CategoryID);
            }
        }

        private void LoadProductsByCategory(int categoryId)
        {
            // Tải danh sách CategoryName từ cơ sở dữ liệu
            IProductService products = new ProductService();
            List<ProductDTO> productName = products.GetProductsByCategoryId(categoryId); // Lấy danh sách sản phẩm theo CategoryID

            cbProductName.DataSource = productName;
            cbProductName.DisplayMember = "ProductName"; // Hiển thị tên sản phẩm
            cbProductName.ValueMember = "ProductID"; // Giá trị là ProductID

        }

        // Tự điền ProductID theo ProductName
        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductName.SelectedItem != null)
            {
                // Fix: Assign the string value to the Text property of the BunifuTextBox
                tbProductID.Text = ((ProductDTO)cbProductName.SelectedItem).ProductID.ToString();
            }
        }

        //Tự tính tiền dựa vào số lượng và giá
        private void tbTotal_TextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbQuantity.Text) && !string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                int quantity;
                decimal price;

                if (int.TryParse(tbQuantity.Text, out quantity) && decimal.TryParse(tbPrice.Text, out price))
                {
                    tbTotal.Text = (quantity * price).ToString();
                }
                else
                {
                    tbTotal.Text = ""; // hoặc "0"
                }
            }
            else
            {
                tbTotal.Text = ""; // hoặc "0"
            }
        }

        // Lưu thông tin đơn hàng vào kho
        private void btSaveStock_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                

                if (string.IsNullOrWhiteSpace(tbQuantity.Text) || !int.TryParse(tbQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Invalid quantity. Please enter a positive whole number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbPrice.Text) || !decimal.TryParse(tbPrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Invalid price. Please enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbTotal.Text) || !decimal.TryParse(tbTotal.Text, out decimal total) || total <= 0)
                {
                    MessageBox.Show("Invalid total. Please make sure the total is calculated correctly.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newStock = new StockDTO
                {
                    productID = int.Parse(tbProductID.Text),
                    categoryName = cbCategoryName.Text,
                    productName = cbProductName.Text,
                    cost = total,
                    stockQuantity = quantity,
                    importDate = importDate.Value.Date,
                    expiryDate = expiryDate.Value.Date
                };

                // Validate business logic
                //StockServiceBLL.Validate(newStock);
                _stockService.Validate(newStock);

                // Confirm with the user
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to add this stock item?",
                    "Confirm Add",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                _stockService.AddStock(newStock);
                RefreshStockTab();
                ClearInputFields(); // Xóa dữ liệu trong các ô nhập liệu
                MessageBox.Show("Stock added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Phuơng thức xóa dữ liệu trong các ô nhập liệu
        private void ClearInputFields()
        {
            tbQuantity.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbTotal.Text = string.Empty;
            importDate.Value = DateTime.Now;
            expiryDate.Value = DateTime.Now.AddDays(30); // Thay đổi số ngày theo yêu cầu
        }

        //Hiển thị dòng được chọn trong DataGridView lên các ô nhập liệu
        private void viewStockToOrder_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (viewStockToOrder.SelectedRows.Count > 0)
                {
                    var selectedStock = (StockDTO)viewStockToOrder.SelectedRows[0].DataBoundItem;

                    // Hiển thị tên danh mục và tên sản phẩm lên ComboBox
                    cbCategoryName.SelectedValue = selectedStock.categoryID; // Chọn danh mục dựa trên CategoryID
                    LoadProductsByCategory(selectedStock.categoryID); // Tải danh sách sản phẩm tương ứng
                    cbProductName.SelectedValue = selectedStock.productID; // Chọn sản phẩm dựa trên ProductID
                }
                else
                {
                    // Nếu không có dòng nào được chọn, làm trống các ComboBox
                    cbCategoryName.SelectedIndex = -1; // Bỏ chọn danh mục
                    cbProductName.DataSource = null; // Làm trống danh sách sản phẩm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data display error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Tab WareHouse
        private void RefreshWareHouseTab()
        {
            try
            {
                var stock = _stockService.GetAllStocks();
                viewStock.AutoGenerateColumns = false;
                viewStock.DataSource = null;
                viewStock.DataSource = stock;
                viewStock.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when refreshing warehouse list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

       
        public new void Refresh()
        {
            // Gọi lại hàm LoadData để làm mới dữ liệu
            LoadData();
        }
    }
}
