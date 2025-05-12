using Bunifu.UI.WinForms;
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

namespace GUI.UI_SALE
{
    public partial class MainSaleForm: Form
    {
        private Dictionary<string, UserControl> ucCache = new Dictionary<string, UserControl>();
        public MainSaleForm()
        {
            InitializeComponent();
            if(AppSession.IsLoggedIn)
            {
                User_FullName.Text = AppSession.CurrentUser.userName;
            }
            else
            {
                User_FullName.Text = "Annonymous User";
            }
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

        private void MainSaleForm_Load(object sender, EventArgs e)
        {
            LoadUserControl("sellingView", () => new SellingUC());
        }

        private void sellingViewBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl("sellingView", () => new SellingUC());
        }

        private void invoiceViewBtn_Click(object sender, EventArgs e)
        {
            //LoadUserControl("invoiceView", () => new InvoiceUC());
        }

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
    }
}
