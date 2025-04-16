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
    public partial class EmployeeManagement: UserControl
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }



        private void btAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm temp = new AddUserForm();
            DialogResult result = temp.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
             
            }
            else
            {
                MessageBox.Show("Login failed", "Error", MessageBoxButtons.OKCancel);
              
            }

        }
    }
}
