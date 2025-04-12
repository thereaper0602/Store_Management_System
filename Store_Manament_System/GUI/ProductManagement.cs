using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using System.Xml.Serialization;
using DAL;

namespace GUI
{
    public partial class ProductManagement: UserControl
    {
        private readonly ProductService prodService;
        public ProductManagement()
        {
            InitializeComponent();
            prodService = new ProductService();
            loadColumn();
        }

        private void loadColumn()
        {
            productDataGridView.AutoGenerateColumns = false;

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "ID",
                Width = 20,
                ReadOnly = true
            });

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                HeaderText = "Product name",
                Width = 200
            });

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "description",
                HeaderText = "Description",
                Width = 200
            });

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "categoryID",
                HeaderText = "Category ID",
                Width = 20
            });

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "stockQuantity",
                HeaderText = "Stock quantity",
                Width = 50
            });

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "price",
                HeaderText = "Price",
                Width = 50
            });

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "expiryDate",
                HeaderText = "Expiry date",
                Width = 200
            });
        }

        public void loadProducts()
        {
            var products = prodService.GetAllProducts();
            productDataGridView.DataSource = products;
        }

        


        private void addBtn_Click(object sender, EventArgs e)
        {
            //bunifuPages1.SetPage(1);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton23_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            //bunifuPages1.SetPage(2);
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            
        }
    }
}
