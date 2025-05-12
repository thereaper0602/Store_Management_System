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
using DTO.DTO;
using GUI.UI_ADMIN;


namespace GUI
{
    public partial class MainForm: Form
    {
        private Dictionary<string, UserControl> ucCache = new Dictionary<string, UserControl>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadUserControl(string key, Func<UserControl> ucFactory)
        {
            if (!ucCache.ContainsKey(key))
            {
                ucCache.Add(key, ucFactory());
            }

            bunifuPanel3.Controls.Clear();
            var uc = ucCache[key];
            if (uc != null)
            {
                bunifuPanel3.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
        }


        //Xử lý nút sign out
        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sign out now?", "Sign Out", MessageBoxButtons.YesNo);
            AppSession.CurrentUser = null; // Đặt lại thông tin người dùng hiện tại
            if (result == DialogResult.No)
            {
                return; // Nếu người dùng chọn "No", không làm gì cả
            }
            if (result == DialogResult.Yes)
            {
                // Tìm lại form Login đã bị ẩn (nếu có)
                Login loginForm = Application.OpenForms.OfType<Login>().FirstOrDefault();

                if (loginForm != null)
                {
                    loginForm.Show();// Hiển thị lại form Login
                    loginForm.clearForm();
                    this.Hide();      // Ẩn MainForm thay vì đóng
                }
                else
                {
                    // Nếu không tìm thấy (trường hợp bất thường), tạo mới
                    loginForm = new Login();
                    loginForm.Show();
                    this.Close();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserControl("productManagement", () => new ProductManagement());
        }

        private void productViewBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl("productManagement", () => new ProductManagement());
        }

        private void categoryViewBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl("categoryManagement", () => new CategoryManagement());
        }

        private void stockViewBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl("stockManagement", () => new StockManagement());
        }

        private void employeeViewBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl("employeeManagement", () => new EmployeeManagement());
        }

        private void promotionViewBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl("promotionManagement", () => new Promotion());
        }

        private void statsViewBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl("statisticReport", () => new Statistics());
        }
    }
}
