using BLL.Services;
using DTO.DTO;
using GUI.UI_SALE;
using GUI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{

    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();

        }
     
        private void Login_Load(object sender, EventArgs e)
        {
            enterPass.PasswordChar = '●';
        }
        private void bt_Login_Click(object sender, EventArgs e)
        {
            // Lấy username và password từ các ô nhập
            string username = enterUser.Text.Trim();
            string password = enterPass.Text.Trim();

            // Gọi nghiệp vụ đăng nhập từ tầng BLL
            LoginBLL loginBLL = new LoginBLL();
            UserDTO user = loginBLL.Login(username, password);

            // Kiểm tra kết quả đăng nhập
            if (user != null)
        {
                AppSession.CurrentUser = user; // Lưu thông tin người dùng
                MessageBox.Show($" Welcome back {user.fullName}!\n The homepage is uploading ");

                if (user.roleID == 1) // Admin
                {
                    MainForm main = new MainForm(); 
                    main.Show();
        }
                else // Nhân viên
        {
                    MainSaleForm staff = new MainSaleForm();
                    staff.Show(); 
                }

                // Ẩn form đăng nhập sau khi đăng nhập thành công
                this.Hide(); 
        }
            else
        {
                MessageBox.Show("Incorrect username or password!");
            }
        }

        private void txtPassword_CheckedChanged(object sender, EventArgs e)
        {

            enterPass.PasswordChar = (txtPassword.Checked) ? '\0' : '●';
        }
    }
}
