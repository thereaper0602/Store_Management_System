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


        private void addBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton23_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        //private void editBtn_Click(object sender, EventArgs e)
        //{
        //    //prodPages.SetPage(1);
        //}

        //private void viewBtn_Click(object sender, EventArgs e)
        //{
        //    prodPages.SetPage(0);
        //}
    }
}
