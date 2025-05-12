using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 // thêm 2 thư viện vào 
using DTO.DTO;
using BLL.Services;
using System.Globalization;
using System.IO;


namespace GUI
{
    public partial class EmployeeManagement : UserControl
    {
        //Khai báo biến
        private readonly IEmployeeServiceBLL _employeeService;

        // Thêm ImageServiceBLL
        private readonly IImageServiceBLL _imageService;



        public EmployeeManagement()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                //khởi tạo biến
                _employeeService = new EmployeeServiceBLL();

                _imageService = new ImageServiceBLL();


                cbMonth.SelectedIndexChanged += (s, e) =>
                {

                    RefreshSalaryTab();
                };
                cbYear.SelectedIndexChanged += (s, e) =>
                {

                    RefreshSalaryTab();
                };
            }
            // Cấu hình EPPlus
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                // Load dữ liệu cho tab hiện tại (mặc định là Information)
                RefreshTabData();
                LoadWorkShift();

                // Đăng ký sự kiện khi chuyển tab
                tabControlEmployee.SelectedIndexChanged += TabControlEmployee_SelectedIndexChanged;

                LoadMonthsIntoComboBox(cbMonth);
                LoadYearsIntoComboBox(cbYear);
            }
        }
        private void TabControlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Làm mới dữ liệu khi chuyển tab
            RefreshTabData();
        }

        private void RefreshTabData()
        {
            switch (tabControlEmployee.SelectedIndex)
            {
                // Tab Information
                case 0:
                    RefreshInformationTab();
                    break;
                // Tab WorkShift
                case 1:
                    RefreshWorkShiftTab();
                    break;
                // Tab Salary
                case 2:
                    RefreshSalaryTab();
                    break;
            }
        }


        #region Tab Information

        // Phương thức này sẽ được gọi khi tab Information được chọn
        private void RefreshInformationTab()
        {
            try
            {
                var employees = _employeeService.GetAllUser();
                viewUser.AutoGenerateColumns = false;
                viewUser.DataSource = null;
                viewUser.DataSource = employees;
                viewUser.Refresh();

                // Đặt lại trạng thái checkbox
                foreach (DataGridViewRow row in viewUser.Rows)
                {
                    row.Cells["Select"].Value = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when refreshing staff list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  phương thức thêm nhân viên 
        private void btAddUser_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddUserForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshInformationTab();
                }
            }
        }

        private void btEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewUser.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please choose an employee to edit!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = viewUser.SelectedRows[0];
                var employee = selectedRow.DataBoundItem as UserDTO;
                if (employee == null)
                {
                    MessageBox.Show("Can't get employee data!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var editForm = new AddUserForm(employee))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshInformationTab();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (viewUser == null)
                {
                    MessageBox.Show("DatagridView is not created!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<int> userIdsToDelete = new List<int>();
                List<UserDTO> usersToDelete = new List<UserDTO>();

                foreach (DataGridViewRow row in viewUser.Rows)
                {
                    DataGridViewCheckBoxCell chk = row.Cells["Select"] as DataGridViewCheckBoxCell;
                    if (chk != null && Convert.ToBoolean(chk.Value) == true)
                    {
                        var employee = row.DataBoundItem as UserDTO;
                        if (employee != null)
                        {
                            userIdsToDelete.Add(employee.userID);
                            usersToDelete.Add(employee);
                        }
                    }
                }

                if (userIdsToDelete.Count == 0 && viewUser.SelectedRows.Count > 0)
                {
                    var selectedRow = viewUser.SelectedRows[0];
                    var employee = selectedRow.DataBoundItem as UserDTO;
                    if (employee != null)
                    {
                        userIdsToDelete.Add(employee.userID);
                        usersToDelete.Add(employee);
                    }
                }

                if (userIdsToDelete.Count == 0)
                {
                    MessageBox.Show("Please choose at least one user to delete!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string confirmMessage = userIdsToDelete.Count == 1
                    ? $"Are you sure you want to delete {usersToDelete[0].fullName} staff?"
                    : $"Are you sure you want to delete these {userIdsToDelete.Count} employees?";
                DialogResult confirmResult = MessageBox.Show(confirmMessage, "Confirm delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                if (_imageService == null)
                {
                    MessageBox.Show("Image is not created!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool result;
                if (userIdsToDelete.Count == 1)
                {
                    var user = usersToDelete[0];
                    ImageDTO imageDto = null;
                    if (user.imageID > 0)
                    {
                        imageDto = _imageService.GetImageById(user.imageID);
                    }
                    result = _employeeService.DeleteUser(user.userID, imageDto);
                }
                else
                {
                    result = _employeeService.DeleteUsers(userIdsToDelete);
                }

                if (result)
                {
                    MessageBox.Show("Successful erasing!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshInformationTab();
                }
                else
                {
                    MessageBox.Show("Delete failure!", "Error",
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
        private System.Threading.Timer searchTimer;
        //tính năng tự động tìm kiếm khi nhập với độ trễ để tối ưu hiệu suất
        private void tbSearchUser_TextChanged(object sender, EventArgs e)
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
                        string keyword = tbSearchUser.Text.Trim();
                        FilterUsers(keyword);
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
        private void btSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = tbSearchUser.Text.Trim();
                FilterUsers(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No found!: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức lọc cập nhật DataGridView
        private void FilterUsers(string keyword)
        {
            try
            {
                // Kiểm tra nếu từ khóa là số (tìm theo ID) hoặc chuỗi (tìm theo tên)
                var filteredPromotions = _employeeService.SearchUser(keyword);

                viewUser.DataSource = null;
                viewUser.DataSource = filteredPromotions;
                viewUser.Refresh();

                // Hiển thị thông báo nếu không tìm thấy
                if (filteredPromotions.Count == 0)
                {
                    MessageBox.Show("Do not find the right user.", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when filtering user data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
               // ClearInputFields();
            }
        }

        #endregion

        #region Tab WorkShift
        private void RefreshWorkShiftTab()
        {
            try
            {
                var workShifts = _employeeService.GetAllUserWorkShift(); ; 
                viewWorkShift.AutoGenerateColumns = false;
                viewWorkShift.DataSource = null;
                viewWorkShift.DataSource = workShifts;
                viewWorkShift.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when refreshing the working shift list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //lay du lieu tu sql workshift vao combobox
        private void LoadWorkShift()
        {
            try
            {
                WorkShiftServiceBLL workShiftService = new WorkShiftServiceBLL();
                List<WorkShiftDTO> WorkShift = workShiftService.GetAllWorkShift();
                if (WorkShift != null && WorkShift.Count > 0)
                {
                    cbWorkShiftName.DataSource = WorkShift;
                    cbWorkShiftName.DisplayMember = "workShiftName";
                    cbWorkShiftName.ValueMember = "workShiftID";
                }
                else
                {
                    MessageBox.Show("No shift found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when downloading the shift list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUserIDWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (!int.TryParse(tbUserIDWork.Text, out int userId))
                    {
                        MessageBox.Show("UserID must be integer!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbUserIDWork.Clear();
                        tbFullNameWork.Clear();
                        return;
                    }

                    // Kiểm tra UserID có hợp lệ và RoleID = 2 không
                    if (!_employeeService.IsValidUserWithRole(userId))
                    {
                        MessageBox.Show("Employee code does not exist !", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbUserIDWork.Clear();
                        tbFullNameWork.Clear();
                        return;
                    }

                    // Lấy FullName và điền vào tbFullName
                    string fullName = _employeeService.GetFullNameByUserId(userId);
                    tbFullNameWork.Text = fullName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btAddWorkShift_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate UserID
                if (!int.TryParse(tbUserIDWork.Text, out int userId))
                {
                    MessageBox.Show("UserID must be an integer!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate UserID and RoleID = 2
                if (!_employeeService.IsValidUserWithRole(userId))
                {
                    MessageBox.Show("UserID does not exist or does not have RoleID = 2!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate WorkShiftID from ComboBox
                if (cbWorkShiftName.SelectedValue == null)
                {
                    MessageBox.Show("Please select a work shift!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int workShiftId = (int)cbWorkShiftName.SelectedValue;
                DateTime workDate = DateTime.Today; // Default to today

                // Check if the user already has a work shift on the same date
                if (_employeeService.HasWorkShiftOnDate(userId, workDate))
                {
                    MessageBox.Show("This employee is already assigned to a work shift on this date!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create UserWorkShiftDTO
                var userWorkShiftDto = new UserWorkShiftDTO
                {
                    userID = userId,
                    workShiftID = workShiftId,
                    workDate = workDate
                };

                // Add to database
                bool result = _employeeService.AddUserWorkShift(userWorkShiftDto);
                if (result)
                {
                    MessageBox.Show("Work shift added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshWorkShiftTab();
                    tbUserIDWork.Clear();
                    tbFullNameWork.Clear();
                    cbWorkShiftName.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Failed to add work shift!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Tab Salary
        private void LoadMonthsIntoComboBox(ComboBox cbMonth)
        {
            // Lấy tháng hiện tại và tháng trước đó
            int currentMonth = DateTime.Now.Month;
            int previousMonth = currentMonth - 1;

            // Nếu tháng trước là 0 (tháng 1), đặt thành tháng 12
            if (previousMonth < 1)
            {
                previousMonth = 12;
            }

            // Tạo danh sách tên đầy đủ của các tháng (January, February,...)
            var months = new List<string>();
            for (int i = 1; i <= 12; i++)
            {
                months.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(i)); // Lấy tên đầy đủ
            }

            // Gán danh sách vào ComboBox
            cbMonth.DataSource = months;

            // Đặt mặc định là tháng trước
            cbMonth.SelectedIndex = previousMonth - 1; // Vì index bắt đầu từ 0
        }

        private void LoadYearsIntoComboBox(ComboBox cbYear, int range = 5)
        {
            // Lấy năm hiện tại
            int currentYear = DateTime.Now.Year;

            // Tạo danh sách năm (từ năm hiện tại - range đến năm hiện tại + range)
            var years = new List<int>();
            for (int i = currentYear - range; i <= currentYear + range; i++)
            {
                years.Add(i);
            }

            // Gán danh sách vào ComboBox
            cbYear.DataSource = years;

            // Đặt mặc định là năm hiện tại
            cbYear.SelectedItem = currentYear;
        }

        private void RefreshSalaryTab()
        {
            try
            {
                if (cbMonth.SelectedItem == null || cbYear.SelectedItem == null)
                {
                    return; // Nếu chưa chọn tháng hoặc năm, không làm mới
                }

                // Lấy tháng từ chỉ số của cbMonth (index từ 0, tháng từ 1)
                int month = cbMonth.SelectedIndex + 1;
                // Lấy năm từ cbYear
                int year = (int)cbYear.SelectedItem;

                var salaries = _employeeService.GetSalariesByMonthAndYear(month, year);
                viewSalary.AutoGenerateColumns = false;
                viewSalary.DataSource = null;
                viewSalary.DataSource = salaries;
                viewSalary.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when refreshing the salary list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        #endregion
    }

}

