using BLL.Services;
using DTO.DTO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;

using Org.BouncyCastle.Asn1.Cmp;
using BLL.Services.Implements;
using GUI.Utils;

namespace GUI.UI_SALE
{
    public partial class InvoicesUC : UserControl
    {
        private readonly IInvoiceG_ServiceBLL invoiceBLL = new InvoiceG_ServiceBLL();
        private readonly IInvoiceStatusServiceBLL invoiceStatusBLL = new InvoiceStatusServiceBLL();
        public InvoicesUC()
        {
            InitializeComponent();
        }

        //private void InvoicesUC_Load(object sender, EventArgs e)
        //{
        //    if (!DesignMode)
        //    {
        //        LoadInvoices();
        //        LoadStatusComboBox();
        //    }
        //    //Invoices_History.AutoGenerateColumns = false;

        //}
        //private void LoadInvoices()
        //{
        //    if (!DesignMode)
        //    {
        //        var data = invoiceBLL.GetAllInvoices(AppSession.CurrentUser.userID);
        //        Invoices_History.DataSource = data;
        //    }

        //}

        private void InvoicesUC_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                // Configure columns before loading data
                ConfigureDataGridViewColumns();
                LoadInvoices();
                LoadStatusComboBox();
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            Invoices_History.Columns.Clear();
            Invoices_History.AutoGenerateColumns = true;

            // Add columns manually with proper DataPropertyName
            Invoices_History.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Invoice ID",
                DataPropertyName = "InvoiceID"
            });

            Invoices_History.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Date",
                DataPropertyName = "CreatedDate",
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Format = "dd/MM/yyyy HH:mm"
                }
            });

            Invoices_History.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Total",
                DataPropertyName = "TotalPrice",
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Format = "N0",
                    NullValue = "0"
                }
            });

            Invoices_History.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Status",
                DataPropertyName = "StatusName"
            });
        }


        private void LoadInvoices()
        {
            if (!DesignMode)
            {
                var data = invoiceBLL.GetAllInvoices(AppSession.CurrentUser.userID);
                Invoices_History.DataSource = data;
            }
        }

        /*
         * if (Invoices_History.CurrentRow != null)
            {
                int invoiceID = Convert.ToInt32(Invoices_History.CurrentRow.Cells["InvoiceID"].Value);
                if (!DesignMode)
                {
                    var invoice = invoiceBLL.GetAllInvoices().FirstOrDefault(i => i.InvoiceID == invoiceID);
                    if (invoice != null)
                    {
                        DetailTable.DataSource = invoice.InvoiceDetails;
                    }
                }
            }
         */

        private void Invoices_History_SelectionChanged(object sender, EventArgs e)
        {
            if (Invoices_History.CurrentRow != null)
            {
                int invoiceID = Convert.ToInt32(Invoices_History.CurrentRow.Cells["InvoiceID"].Value);
                if (!DesignMode)
                {
                    var invoice = invoiceBLL.GetAllInvoices(AppSession.CurrentUser.userID).FirstOrDefault(i => i.InvoiceID == invoiceID);
                    if (invoice != null)
                    {
                        DetailTable.DataSource = invoice.InvoiceDetails;
                    }
                }
            }

        }

        private void delete_invoice_Click(object sender, EventArgs e)
        {

            if ((Invoices_History.CurrentRow != null))
            {
                int invoiceID = Convert.ToInt32((Invoices_History.CurrentRow.Cells["InvoiceID"].Value));
                var confirm = MessageBox.Show("Delete this invoice?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool result = invoiceBLL.DeleteInvoice(invoiceID);
                    if (result)
                    {
                        MessageBox.Show("Invoice deleted.");
                        LoadInvoices();
                        DetailTable.DataSource = null;
                    }
                }
            }
        }


        private void searchInvoices_TextChange(object sender, EventArgs e)
        {
            string keyword = searchInvoices.Text.Trim().ToLower();

            if (Invoices_History.DataSource is List<InvoiceG_DTO> currentData)
            {
                var filtered = currentData.Where(i =>
                    i.InvoiceID.ToString().Contains(keyword) ||
                    i.UserID.ToString().Contains(keyword) ||
                    i.CreatedDate.ToString("dd/MM/yyyy").Contains(keyword) ||
                    (i.TotalPrice != null && i.TotalPrice.ToString().Contains(keyword)) ||
                    (i.Change != null && i.Change.ToString().Contains(keyword)) ||
                    (i.StatusName != null && i.StatusName.ToLower().Contains(keyword))
                ).ToList();

                Invoices_History.DataSource = filtered;
            }
        }

        private void print_invoice_Click(object sender, EventArgs e)
        {
            if (Invoices_History.CurrentRow != null)
            {
                int invoiceID = Convert.ToInt32(Invoices_History.CurrentRow.Cells["InvoiceID"].Value);
                var invoice = invoiceBLL.GetAllInvoices(AppSession.CurrentUser.userID).FirstOrDefault(i => i.InvoiceID == invoiceID);
                var details = invoice?.InvoiceDetails.ToList();

                if (invoice != null && details != null)
                {
                    // Tạo file PDF tạm thời
                    string tempFilePath = Path.Combine(Path.GetTempPath(), $"Invoice_{invoice.InvoiceID}_preview.pdf");
                    ExportInvoiceToPdf(invoice, details, tempFilePath);

                    try
                    {
                        // Mở hộp thoại in của hệ thống
                        using (PrintDialog printDialog = new PrintDialog())
                        {
                            printDialog.AllowSomePages = true;
                            printDialog.ShowHelp = true;
                            printDialog.Document = new PrintDocument();

                            if (printDialog.ShowDialog() == DialogResult.OK)
                            {
                                // Sử dụng Process.Start để mở file PDF và in
                                ProcessStartInfo psi = new ProcessStartInfo
                                {
                                    FileName = tempFilePath,
                                    Verb = "print",
                                    UseShellExecute = true,
                                    CreateNoWindow = true
                                };
                                Process.Start(psi);
                            }
                        }

                        // Sau khi in, mở hộp thoại lưu file PDF
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                            //Lưu hóa đơn PDF
                            saveFileDialog.Title = "Save Invoice as PDF";
                            saveFileDialog.FileName = $"Invoice_{invoice.InvoiceID}.pdf";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                File.Copy(tempFilePath, saveFileDialog.FileName, true);
                                //Lưu hóa đơn thành công
                                MessageBox.Show("Invoice has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //Lỗi khi in hoặc lưu file 
                        MessageBox.Show($"An error occurred while printing or saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Xóa file tạm
                        if (File.Exists(tempFilePath))
                        {
                            try
                            {
                                File.Delete(tempFilePath);
                            }
                            catch (Exception ex)
                            {
                                //Lỗi khi xóa file tạm
                                MessageBox.Show($"Failed to delete the temporary file: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    //Không thể xử lý hóa đơn!
                    MessageBox.Show("Unable to process the invoice!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ExportInvoiceToPdf(InvoiceG_DTO invoice, List<InvoiceDetailG_DTO> details, string filePath)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Add the title and other details
            doc.Add(new Paragraph($"Invoice ID: {invoice.InvoiceID}"));
            doc.Add(new Paragraph($"User ID: {invoice.UserID}"));
            doc.Add(new Paragraph($"Created Date: {invoice.CreatedDate:dd/MM/yyyy HH:mm}"));
            doc.Add(new Paragraph($"Total Amount: {invoice.TotalPrice:N0} VND"));
            doc.Add(new Paragraph($"Change: {invoice.Change:N0} VND"));
            doc.Add(new Paragraph($"Status: {invoice.StatusID}"));
            doc.Add(new Paragraph(" ")); // Blank line

            // Create the detail table
            PdfPTable table = new PdfPTable(5);
            table.AddCell("Product Code");
            table.AddCell("Quantity");
            table.AddCell("Unit Price");
            table.AddCell("Line Total");
            table.AddCell("Detail ID");


            foreach (var item in details)
            {
                table.AddCell(item.ProductID.ToString());
                table.AddCell(item.Quantity.ToString());
                table.AddCell(item.UnitPrice.ToString("N0"));
                table.AddCell(item.LineTotal.ToString("N0"));
                table.AddCell(item.DetailID.ToString());
            }

            doc.Add(table);
            doc.Close();
        }
        private void LoadStatusComboBox()
        {
            var statuses = invoiceStatusBLL.GetAllInvoiceStatuses();

            // Thêm "All Status..." vào đầu danh sách
            statuses.Insert(0, new InvoiceStatusDTO { InvoiceStatusID = 0, InvoiceStatusName = "All Status..." });

            cbStatus.DisplayMember = "InvoiceStatusName"; // Tên hiển thị
            cbStatus.ValueMember = "InvoiceStatusID";     // Giá trị thực tế
            cbStatus.DataSource = statuses;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedValue != null && int.TryParse(cbStatus.SelectedValue.ToString(), out int selectedStatus))
            {
                if (selectedStatus == 0)
                {
                    Invoices_History.DataSource = invoiceBLL.GetAllInvoices(AppSession.CurrentUser.userID);
                }
                else
                {
                    Invoices_History.DataSource = invoiceBLL.GetInvoicesByStatus(selectedStatus,AppSession.CurrentUser.userID);
                }
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {

            string keyword = searchInvoices.Text.Trim();  // Từ khóa tìm kiếm
            DateTime fromDate = invoiceTimeFrom.Value.Date;  // Ngày bắt đầu
            DateTime toDate = invoiceTimeTo.Value.Date;  // Ngày kết thúc
            string statusName = cbStatus.SelectedItem?.ToString();  // Trạng thái

            // Kiểm tra nếu ngày bắt đầu lớn hơn ngày kết thúc
            if (fromDate > toDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi phương thức lọc trong BLL
            var result = invoiceBLL.FilterInvoices(keyword, fromDate, toDate, statusName);

            // Hiển thị kết quả lên DataGridView
            Invoices_History.DataSource = result;

            // Kiểm tra nếu không có kết quả phù hợp
            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}