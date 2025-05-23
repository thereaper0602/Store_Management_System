﻿using DTO.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace GUI.UI_SALE
{
    public partial class PaymentForm : Form
    {
        public int InvoiceID { get; set; }
        private readonly InvoiceDTO invoiceDTO;
        private readonly IInvoiceServiceBLL invoiceServiceBLL = new InvoiceServiceBLL();
        private readonly IProductService _prodService = new ProductService();
        public PaymentForm(InvoiceDTO invoice)
        {
            InitializeComponent();
            invoiceDTO = invoice;
            SetupDataGridView();
            loadUI();
        }

        private void SetupDataGridView()
        {
            dgvPaymentItems.Columns.Clear();

            dgvPaymentItems.Columns.Add("ProductID", "Product ID");
            dgvPaymentItems.Columns.Add("ProductName", "Product Name");
            dgvPaymentItems.Columns.Add("UnitPrice", "Unit Price");
            dgvPaymentItems.Columns.Add("Quantity", "Quantity");
            dgvPaymentItems.Columns.Add("LineTotal", "Total");

            dgvPaymentItems.Columns["ProductID"].Visible = false;
            dgvPaymentItems.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
            dgvPaymentItems.Columns["LineTotal"].DefaultCellStyle.Format = "N0";
        }

        private void loadUI()
        {
            createdDate.Text = DateTime.Now.ToString();
            totalPriceLbl.Text = invoiceDTO.TotalPrice.ToString("N0") + " đ";

            foreach (var item in invoiceDTO.InvoiceDetails)
            {
                dgvPaymentItems.Rows.Add(
                    item.ProductID,
                    this.getProductName(item.ProductID),
                    item.UnitPrice.ToString("N0"),
                    item.Quantity,
                    item.LineTotal.ToString("N0")
                );
            }
        }

        private string getProductName(int? productID)
        {
            var product = _prodService.GetProductById((int)productID);
            return product?.ProductName ?? "N/A";
        }

        private void cashBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerPayTxtBox.Text))
            {
                MessageBox.Show("Please enter the amount paid by the customer.");
                return;
            }

            try
            {
                invoiceDTO.StatusID = 2;
                if (decimal.TryParse(customerPayTxtBox.Text, out decimal customerPay))
                {
                    if (customerPay < invoiceDTO.TotalPrice)
                    {
                        MessageBox.Show("The amount paid is not enough.");
                        return;
                    }
                    decimal change = customerPay - invoiceDTO.TotalPrice;
                    changeTxtBox.Text = change.ToString("N0") + " ₫";
                    int invoiceID = invoiceServiceBLL.CreateInvoice(invoiceDTO);
                    if (invoiceID > 0)
                    {
                        MessageBox.Show("Payment successful. Invoice ID: " + invoiceID);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Payment failed.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid amount entered.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ewalletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var qrForm = new PaymentQRForm(invoiceDTO))
                {
                    var result = qrForm.ShowDialog();

                    if (result == DialogResult.OK && qrForm.PaymentSuccess)
                    {
                        invoiceDTO.StatusID = 2;
                        int invoiceID = invoiceServiceBLL.CreateInvoice(invoiceDTO);

                        if (invoiceID > 0)
                        {
                            MessageBox.Show("Payment successful. Invoice ID: " + invoiceID, "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Payment failed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Payment was cancelled or failed.");
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
