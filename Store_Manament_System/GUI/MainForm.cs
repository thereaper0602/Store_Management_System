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
namespace GUI
{
    public partial class MainForm: Form
    {
        public MainForm()
        {

            InitializeComponent();
            productManagement1.loadProducts();

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSideMenu_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);
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
                this.Close();    // Đóng form hiện tại (form chính)
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            User_FullName.Text = AppSession.CurrentUser.fullName;
        }
    }
}
