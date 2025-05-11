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
    }
}
