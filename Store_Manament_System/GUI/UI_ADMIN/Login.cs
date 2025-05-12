using BLL.Services;
using DTO.DTO;
using GUI.UI_SALE;
using GUI.Utils;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GUI
{

    public partial class Login : Form
    {
        private readonly ILoginBLL loginBLL = new LoginBLL();
        public Login()
        {
            InitializeComponent();
        }

        public void clearForm()
        {
            enterPass.Clear();
            enterUser.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            enterPass.PasswordChar = '●';
        }
        private void bt_Login_Click(object sender, EventArgs e)
        {
            string username = enterUser.Text.Trim();
            string password = enterPass.Text.Trim();
            UserDTO user = loginBLL.Login(username, password);

            if (user != null)
            {
                AppSession.CurrentUser = user;
                MessageBox.Show($"Welcome back {user.fullName}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HandleLoginSuccess(user);
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HandleLoginSuccess(UserDTO user)
        {
            this.Hide();

            Form mainForm = user.roleID == 1 ? new MainForm() : new MainSaleForm();
            mainForm.FormClosed += (s, args) => this.Close();  // Close login when main form closes
            mainForm.Show();  // Changed from ShowDialog() to Show()
        }


        private void txtPassword_CheckedChanged(object sender, EventArgs e)
        {
            enterPass.PasswordChar = (txtPassword.Checked) ? '\0' : '●';
        }
    }
}
