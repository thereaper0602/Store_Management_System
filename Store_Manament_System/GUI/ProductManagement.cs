using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProductManagement: UserControl
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            prodPages.SetPage(1);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            prodPages.SetPage(0);
        }
    }
}
