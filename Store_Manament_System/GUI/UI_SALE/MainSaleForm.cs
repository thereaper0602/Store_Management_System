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
        public MainSaleForm()
        {
            InitializeComponent();
            if(AppSession.IsLoggedIn)
            {
                bunifuLabel3.Text = AppSession.CurrentUser.username;
            }
            else
            {
                bunifuLabel3.Text = "Annonymous User";
            }
        }

        private void btnSideMenu_Click(object sender, EventArgs e)
        {
            bunifuPages.SetPage(((Control)sender).Text);
        }
    }
}
