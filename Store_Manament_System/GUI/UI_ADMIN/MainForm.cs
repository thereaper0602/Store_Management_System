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
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Sign out now?", "Sign Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Tạo lại form đăng nhập
                Login loginForm = new Login();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.TopMost = true;
                loginForm.Show();
                this.Close();
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
