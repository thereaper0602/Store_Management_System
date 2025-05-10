using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using DTO.DTO;

namespace GUI
{
    public partial class Promotion : UserControl
    {
        private readonly PromotionServiceBLL _promotionService = new PromotionServiceBLL();
        private readonly ProductService _productService = new ProductService();
        private readonly ProductPromotionBLL _productPromotionService = new ProductPromotionBLL();

        // biến lưu khuyến mãi được chọn để chỉnh sửa
        private PromotionDTO _selectedPromotion; 

        public Promotion()
        {
            InitializeComponent();
        }

        private void Promotion_Load(object sender, EventArgs e)
        {
            try
            {
                if (!DesignMode)
                {
                    RefreshPromotionTab();
                    
                    LoadCategoryName();
                    LoadPromotionName();
                }
                
                _selectedPromotion = null;

                // Thiết lập mặc định cho DateTimePicker
                fromDate.Value = DateTime.Now;
                // Mặc định kết thúc sau 7 ngày
                toDate.Value = DateTime.Now.AddDays(7);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when downloading the promotion list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabCtrolPrmotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTabData();
        }

        private void RefreshTabData()
        {
            switch (tabCtrolPromotion.SelectedIndex)
            {
                // Tab Promotion
                case 0:
                    RefreshPromotionTab();
                    break;
                // Tab WorkShift
                case 1:
                    int? categoryId = null;
                    if (cbCateToDeal.SelectedItem != null)
                    {
                        categoryId = ((CategoryDTO)cbCateToDeal.SelectedItem).CategoryID;
                    }
                    RefreshDealsTab(categoryId);
                    break;

            }
        }

        #region Tab Promotion

        // Phương thức tải lại DataGridView
        private void RefreshPromotionTab()
        {
            try
            {
                var promotions = _promotionService.GetAllPromotions();
                viewPromotion.DataSource = null;
                viewPromotion.DataSource = promotions;
                viewPromotion.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when refreshing: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Phuơng thức xóa dữ liệu trong các ô nhập liệu
        private void ClearInputFields()
        {
            tbPromotionName.Text = string.Empty;
            tbDiscount.Text = string.Empty;
            tbDcripPromotion.Text = string.Empty;

            fromDate.Value = DateTime.Now;
            toDate.Value = DateTime.Now.AddDays(7);
            _selectedPromotion = null;
        }

        // Nút thêm khuyến mãi
        private void btAddPromotion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(tbDiscount.Text, out decimal discountRate))
                {
                    MessageBox.Show("Please enter a valid discount format!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var promotionDto = new PromotionDTO
                {
                    promotionName = tbPromotionName.Text,
                    discountRate = discountRate,
                    startDate = fromDate.Value,
                    endDate = toDate.Value,
                    description = tbDcripPromotion.Text
                };

                bool result = _promotionService.AddPromotion(promotionDto);
                if (result)
                {
                    MessageBox.Show("Add successful promotions!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPromotionTab();
                    LoadPromotionName();
                    ClearInputFields();
                }
            }
            catch (ArgumentException ex)
            {
                // Lỗi nghiệp vụ từ BLL
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Phương thức xử lý cập nhật khuyến mãi khi chọn dòng dữ liệu
        private void viewPromotion_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (viewPromotion.SelectedRows.Count > 0)
                {
                    var selectedRow = viewPromotion.SelectedRows[0];
                    _selectedPromotion = (PromotionDTO)selectedRow.DataBoundItem;

                    if (_selectedPromotion != null)
                    {
                        // Hiển thị dữ liệu lên khung Promotion
                       
                        tbPromotionName.Text = _selectedPromotion.promotionName;
                        tbDiscount.Text = _selectedPromotion.discountRate.ToString();
                        tbDcripPromotion.Text = _selectedPromotion.description;
                        fromDate.Value = _selectedPromotion.startDate;
                        toDate.Value = _selectedPromotion.endDate;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data display error {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Nút lưu khuyến mãi sau khi sửa 
        private void btSavePromotion_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedPromotion == null)
                {
                    MessageBox.Show("Please choose a promotion to edit!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(tbDiscount.Text, out decimal discountRate))
                {
                    MessageBox.Show("Please enter a valid discount format!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _selectedPromotion.promotionName = tbPromotionName.Text;
                _selectedPromotion.discountRate = discountRate;
                _selectedPromotion.startDate = fromDate.Value;
                _selectedPromotion.endDate = toDate.Value;
                _selectedPromotion.description = tbDcripPromotion.Text;

                bool result = _promotionService.UpdatePromotion(_selectedPromotion);
                if (result)
                {
                    MessageBox.Show("Update promotion successfully!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPromotionTab();
                    LoadPromotionName();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("No promotions can be found to update!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Nút xóa khuyến mãi
        private void btDeletePromotion_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách các UserID cần xóa
                List<int> vouchersToDelete = new List<int>();

                // Trường hợp 1: Kiểm tra các dòng được tích checkbox
                foreach (DataGridViewRow row in viewPromotion.Rows)
                {
                    // Cột checkbox là cột đầu tiên (index 0)
                    DataGridViewCheckBoxCell chk = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (chk != null && Convert.ToBoolean(chk.Value) == true)
                    {
                        var voucher = (PromotionDTO)row.DataBoundItem;
                        vouchersToDelete.Add(voucher.promotionID);
                    }
                }

                // Trường hợp 2: Nếu không có dòng nào được tích, kiểm tra dòng được chọn
                if (vouchersToDelete.Count == 0 && viewPromotion.SelectedRows.Count > 0)
                {
                    var selectedRow = viewPromotion.SelectedRows[0];
                    var voucher = (PromotionDTO)selectedRow.DataBoundItem;
                    vouchersToDelete.Add(voucher.promotionID);
                }

                // Nếu không có dòng nào được chọn hoặc tích, hiển thị thông báo
                if (vouchersToDelete.Count == 0)
                {
                    MessageBox.Show("Please choose at least one promotion to delete!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xóa
                string confirmMessage = vouchersToDelete.Count == 1
                    ? "Are you sure this?"
                    : $"Are you sure you want to delete these {vouchersToDelete.Count} promotions?";
                DialogResult confirmResult = MessageBox.Show(confirmMessage, "Confirm delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                {
                    // Người dùng hủy xóa
                    return; 
                }

                // Gọi PromotionServiceBLL để xóa
                bool result;
                if (vouchersToDelete.Count == 1)
                {
                    result = _promotionService.DeletePromotion(vouchersToDelete[0]);
                }
                else
                {
                    result = _promotionService.DeletePromotions(vouchersToDelete);
                }

                // Xử lý kết quả
                if (result)
                {
                    MessageBox.Show("Delete success!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPromotionTab(); // Làm mới DataGridView
                    LoadPromotionName();
                }
                else
                {
                    MessageBox.Show("Not found to delete!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện TextChanged của ô tìm kiếm
        //tính năng tự động tìm kiếm khi nhập với độ trễ để tối ưu hiệu suất
        private System.Threading.Timer searchTimer;
        
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // Hủy timer nếu đang chạy
            searchTimer?.Dispose();

            // Tạo timer mới với độ trễ 500ms
            searchTimer = new System.Threading.Timer(_ =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        string keyword = tbSearchPromotion.Text.Trim();
                        FilterPromotions(keyword);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error when searching: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }, null, 500, System.Threading.Timeout.Infinite);
        }


        // Sự kiện Click của nút Search
        private void btSearchPromotion_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = tbSearchPromotion.Text.Trim();
                FilterPromotions(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No promotion found!: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức lọc khuyến mãi và cập nhật DataGridView
        private void FilterPromotions(string keyword)
        {
            try
            {
                // Kiểm tra nếu từ khóa là số (tìm theo ID) hoặc chuỗi (tìm theo tên)
                var filteredPromotions = _promotionService.SearchPromotions(keyword);

                viewPromotion.DataSource = null;
                viewPromotion.DataSource = filteredPromotions;
                viewPromotion.Refresh();

                // Hiển thị thông báo nếu không tìm thấy
                if (filteredPromotions.Count == 0)
                {
                    MessageBox.Show("Do not find the right promotion.", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Nếu có dữ liệu, chọn dòng đầu tiên và hiển thị lên khung
                if (viewPromotion.Rows.Count > 0)
                {
                    viewPromotion.ClearSelection();
                    viewPromotion.Rows[0].Selected = true;
                    viewPromotion_SelectionChanged(null, null);
                }
                else
                {
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when filtering promotion data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputFields();
            }
        }
        #endregion

        #region Tab Deals
        

        private void RefreshDealsTab(int? categoryId = null)
        {
            try
            {
                viewProductToDeals.AutoGenerateColumns = false;

                List<ProductDTO> products;
                if (categoryId.HasValue)
                {
                    products = _productService.GetProductsByCategoryId(categoryId.Value);
                }
                else
                {
                    products = _productService.GetAllProducts("");
                }

                int? promotionId = null;
                if (cbPromotionName.SelectedItem != null)
                {
                    promotionId = ((PromotionDTO)cbPromotionName.SelectedItem).promotionID;
                }

                List<ProductPromotionDTO> productPromotions = new List<ProductPromotionDTO>();
                if (promotionId.HasValue)
                {
                    productPromotions = _productPromotionService.GetProductPromotionsByPromotionId(promotionId.Value);
                }

                viewProductToDeals.DataSource = null;
                viewProductToDeals.DataSource = products;

                foreach (DataGridViewRow row in viewProductToDeals.Rows)
                {
                    var product = (ProductDTO)row.DataBoundItem;
                    bool isSelected = promotionId.HasValue && productPromotions.Any(pp => pp.productID == product.ProductID);
                    row.Cells[0].Value = isSelected;
                    row.ReadOnly = isSelected; // Đặt dòng thành ReadOnly nếu ô "Selected" được tích
                }

                viewProductToDeals.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when refreshing: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCategoryName()
        {
            try
            {
                // Tải danh sách CategoryName từ cơ sở dữ liệu
                CategoryBLL listCate = new CategoryBLL();
                List<CategoryDTO> categoryName = listCate.GetAllCategories();
                if (categoryName != null && categoryName.Count > 0)
                {
                    cbCateToDeal.DataSource = categoryName;
                    cbCateToDeal.DisplayMember = "categoryName";
                    cbCateToDeal.ValueMember = "categoryID";

                    // Đặt lại lựa chọn mặc định (tuỳ chọn)
                    cbCateToDeal.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when downloading the shift list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPromotionName()
        {
            try
            {
                // Lấy danh sách tất cả các Promotion từ cơ sở dữ liệu
                List<PromotionDTO> listPromotion = _promotionService.GetAllPromotions();

                if (listPromotion != null && listPromotion.Count > 0)
                {
                    // Lọc các Promotion có ngày hiện tại nằm trong khoảng startDate và endDate
                    DateTime currentDate = DateTime.Now.Date; // Sử dụng Date để bỏ qua thời gian
                    List<PromotionDTO> filteredPromotions = listPromotion
                        .Where(p => p.startDate.Date <= currentDate && currentDate <= p.endDate.Date)
                        .ToList();

                    if (filteredPromotions != null && filteredPromotions.Count > 0)
                    {
                        cbPromotionName.DataSource = filteredPromotions;
                        cbPromotionName.DisplayMember = "promotionName";
                        cbPromotionName.ValueMember = "promotionID";

                        // Đặt lại lựa chọn mặc định (tuỳ chọn)
                        cbPromotionName.SelectedIndex = -1;
                    }
                    else
                    {
                        // Nếu không có Promotion nào thỏa mãn, xóa dữ liệu ComboBox
                        cbPromotionName.DataSource = null;
                        cbPromotionName.Items.Clear();
                    }
                }
                else
                {
                    // Nếu danh sách ban đầu rỗng hoặc null, xóa dữ liệu ComboBox
                    cbPromotionName.DataSource = null;
                    cbPromotionName.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when downloading the shift list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Sự kiện chọn CategoryName
        private void cbPromotionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPromotionName.SelectedItem != null)
            {
                RefreshDealsTab(cbCateToDeal.SelectedItem != null ? ((CategoryDTO)cbCateToDeal.SelectedItem).CategoryID : (int?)null);
                // Lấy đối tượng PromotionDTO được chọn
                PromotionDTO selectedPromotion = (PromotionDTO)cbPromotionName.SelectedItem;

                // Gán giá trị discountRate
                tbSeeDiscount.Text = selectedPromotion.discountRate.ToString();

                // Kiểm tra và gán giá trị description
                string description = selectedPromotion.description ?? string.Empty;
                tbSeeDescrip.Text = description;

                // Gán giá trị cho DateTimePicker
                seeFromDate.Value = selectedPromotion.startDate;
                seeToDate.Value = selectedPromotion.endDate;
            }
            else
            {
                // Nếu không có item được chọn, đặt lại các ô
                tbSeeDiscount.Text = string.Empty;
                tbDcripPromotion.Text = string.Empty;
                seeFromDate.Value = DateTime.Now; // Đặt lại ngày mặc định
                seeToDate.Value = DateTime.Now;   // Đặt lại ngày mặc định
            }
        }

        private void cbCateToDeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCateToDeal.SelectedItem != null)
            {
                var selectedCategory = (CategoryDTO)cbCateToDeal.SelectedItem;
                int categoryId = selectedCategory.CategoryID;
                RefreshDealsTab(categoryId);
            }
            else
            {
                RefreshDealsTab();
            }
        }
        private void btSaveDeals_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy promotionID từ ComboBox
                int? promotionId = null;
                if (cbPromotionName.SelectedItem != null)
                {
                    promotionId = ((PromotionDTO)cbPromotionName.SelectedItem).promotionID;
                }

                if (!promotionId.HasValue)
                {
                    MessageBox.Show("Please select a promotion first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy danh sách ProductPromotion hiện tại từ cơ sở dữ liệu
                List<ProductPromotionDTO> initialProductPromotions = _productPromotionService.GetProductPromotionsByPromotionId(promotionId.Value);

                // Biến để kiểm tra xem có dòng mới được chọn không (ngoài dữ liệu ban đầu)
                bool hasNewlySelectedProduct = false;

                foreach (DataGridViewRow row in viewProductToDeals.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới nếu có

                    var product = (ProductDTO)row.DataBoundItem;
                    bool isCurrentlySelected = Convert.ToBoolean(row.Cells[0].Value); // Giá trị hiện tại từ DataGridView
                    bool wasInitiallySelected = initialProductPromotions.Any(pp => pp.productID == product.ProductID); // Giá trị ban đầu

                    // Kiểm tra nếu dòng mới được chọn (không có trong dữ liệu ban đầu)
                    if (isCurrentlySelected && !wasInitiallySelected)
                    {
                        hasNewlySelectedProduct = true;
                        var newProductPromotion = new ProductPromotionDTO
                        {
                            productID = product.ProductID,
                            promotionID = promotionId.Value
                        };
                        _productPromotionService.AddProductPromotion(newProductPromotion);
                        row.ReadOnly = true; // Đặt dòng thành ReadOnly sau khi lưu
                    }
                    // Không xử lý xóa (RemoveProductPromotion) trừ khi cần thiết, giữ nguyên các dòng đã tích từ dữ liệu ban đầu
                }

                // Kiểm tra sau khi duyệt tất cả các dòng
                if (!hasNewlySelectedProduct)
                {
                    MessageBox.Show("No product has been selected beyond the initial data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Thoát nếu không có sản phẩm mới được chọn
                }

                MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Làm mới bảng để phản ánh thay đổi
                RefreshDealsTab(cbCateToDeal.SelectedItem != null ? ((CategoryDTO)cbCateToDeal.SelectedItem).CategoryID : (int?)null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        #endregion


    }
}

