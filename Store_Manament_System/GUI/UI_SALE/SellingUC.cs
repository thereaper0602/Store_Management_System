using BLL;
using BLL.Services;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using DTO.DTO;
using GUI.Utils;
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

namespace GUI.UI_SALE
{
    public partial class SellingUC : UserControl
    {
        //private readonly ProductService productService = new ProductService();
        //private List<>
        public SellingUC()
        {
            InitializeComponent();
            //flowLayoutPanel2.WrapContents = false;
            //MessageBox.Show(String.Format("{0}",bunifuShadowPanel6.Size));
        }

        private void SellingUC_Load(object sender, EventArgs e)
        {
            //if (!DesignMode)
            //{
            //    InitializeDataGridView();
            //    LoadProducts();
            //}
        }

        public void LoadProducts()
        {
            //List<ProductDTO> productsToDisplay = productService.GetAvailableProducts(null);
            //ProductFlowLayoutPanel.Controls.Clear();
            //foreach (var product in productsToDisplay)
            //{
            //    var panel = CreateProductPanel(product);
            //    ProductFlowLayoutPanel.Controls.Add(panel);
            //}
        }

        //private BunifuShadowPanel CreateProductPanel(ProductDTO product)
        //{
            //var panel = new BunifuShadowPanel();
            //panel.BorderColor = Color.WhiteSmoke;
            //panel.BackColor = Color.Transparent;
            //panel.BorderRadius = 20;
            //panel.BorderThickness = 1;
            //panel.FillStyle = BunifuShadowPanel.FillStyles.Solid;
            //panel.ForeColor = Color.Black;
            //panel.GradientMode = BunifuShadowPanel.GradientModes.Vertical;
            //panel.Location = new Point(260, 10);
            //panel.Margin = new Padding(8, 0, 4, 4);
            //panel.ShadowColor = Color.DarkGray;
            //panel.ShadowDept = 2;
            //panel.ShadowDepth = 5;
            //panel.ShadowStyle = BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            //panel.ShadowTopLeftVisible = false;
            //panel.Size = new Size(220, 362);
            //panel.Style = BunifuShadowPanel.BevelStyles.Flat;

            //// PictureBox cho hình ảnh sản phẩm
            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Size = new Size(180, 180);
            //pictureBox.Location = new Point(20, 10);
            //pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //ImageDTO image = LoadImageFromID(product.imageID);
            //if (image != null && File.Exists(image.imagePath))
            //{
            //    using (var stream = new FileStream(image.imagePath, FileMode.Open, FileAccess.Read))
            //    {
            //        pictureBox.Image = Image.FromStream(stream);
            //    }
            //}
            //panel.Controls.Add(pictureBox);

            //// Label cho tên sản phẩm
            //Label nameLabel = new Label();
            //nameLabel.Text = product.name;
            //nameLabel.Font = new Font("Poppins", 10, FontStyle.Bold);
            //nameLabel.AutoSize = false;
            //nameLabel.Size = new Size(200, 25);
            //nameLabel.Location = new Point(10, 220);
            //panel.Controls.Add(nameLabel);

            //// Label cho giá sản phẩm
            //Label priceLabel = new Label();
            //priceLabel.Text = product.price.ToString("N0") + " ₫";
            //priceLabel.ForeColor = Color.DarkGreen;
            //priceLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            //priceLabel.AutoSize = false;
            //priceLabel.Size = new Size(200, 25);
            //priceLabel.Location = new Point(10, 250);
            //panel.Controls.Add(priceLabel);

            //// Button thêm vào giỏ hàng
            //BunifuButton2 addButton = new BunifuButton2();
            //addButton.Text = "Add";
            ////addButton.BackColor = Color.SeaGreen;
            //addButton.ForeColor = Color.White;
            //addButton.AutoRoundBorders = true;
            //addButton.Size = new Size(120, 35);
            //addButton.Location = new Point(10, 290);
            //addButton.Click += (sender,e) => AddProductToInvoices(product);
            //panel.Controls.Add(addButton);
            //return panel;
        //}

        //private ImageDTO LoadImageFromID(int id)
        //{
        //    ImageServiceBLL imageService = new ImageServiceBLL();
        //    return imageService.GetImageById(id);
        //}

        private void AddProductToInvoices(ProductDTO product)
        {
            //bool productExists = false;
            //foreach (DataGridViewRow row in invoiceDataGridView.Rows)
            //{
            //    if (row.Cells["ProductID"].Value != null &&
            //        Convert.ToInt32(row.Cells["ProductID"].Value) == product.id)
            //    {
            //        // Tăng số lượng lên 1
            //        int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);

            //        if(currentQuantity >= product.stockQuantity)
            //        {
            //            MessageBox.Show("Not enough stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }

            //        row.Cells["Quantity"].Value = currentQuantity + 1;

            //        // Cập nhật tổng tiền
            //        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
            //        row.Cells["Total"].Value = (currentQuantity + 1) * price;

            //        productExists = true;
            //        break;
            //    }
            //}
            //if(!productExists)
            //{
            //    // Thêm sản phẩm mới vào DataGridView
            //    invoiceDataGridView.Rows.Add(
            //        product.id,
            //        product.name,
            //        product.price,
            //        1,
            //        product.price
            //    );
            //}
            //UpdateCartTotal();
        }

        private void UpdateCartTotal()
        {
            //decimal total = 0;

            //foreach (DataGridViewRow row in invoiceDataGridView.Rows)
            //{
            //    if (row.Cells["Total"].Value != null)
            //    {
            //        total += Convert.ToDecimal(row.Cells["Total"].Value);
            //    }
            //}

            //lblTotal.Text = total.ToString("N0") + " ₫";
        }

        private void InitializeDataGridView()
        {
            // Xóa các cột hiện có nếu cần
            invoiceDataGridView.Columns.Clear();

            // Thêm các cột
            invoiceDataGridView.Columns.Add("ProductID", "ID");
            invoiceDataGridView.Columns["ProductID"].Visible = false; // Ẩn cột ID nếu không cần hiển thị

            invoiceDataGridView.Columns.Add("ProductName", "Name");
            invoiceDataGridView.Columns.Add("Price", "Price");
            invoiceDataGridView.Columns["Price"].DefaultCellStyle.Format = "N0";

            invoiceDataGridView.Columns.Add("Quantity", "Quantity");
            invoiceDataGridView.Columns["Quantity"].Width = 120;

            invoiceDataGridView.Columns.Add("Total", "Total");
            invoiceDataGridView.Columns["Total"].DefaultCellStyle.Format = "N0";

            // Thêm nút xóa nếu cần
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            invoiceDataGridView.Columns.Add(deleteButton);

            // Xử lý sự kiện click nút xóa
            invoiceDataGridView.CellContentClick += (sender, e) =>
            {
                if (invoiceDataGridView.Rows.Count - 1 == 0)
                {
                    return;
                }
                if (e.ColumnIndex == invoiceDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    invoiceDataGridView.Rows.RemoveAt(e.RowIndex);
                    UpdateCartTotal();
                }
            };
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            //// Kiểm tra giỏ hàng, không có thì báo lỗi
            //if (invoiceDataGridView.Rows.Count - 1 == 0)
            //{
            //    MessageBox.Show("Please add items before payment!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //AppSession.CurrentUser = new DTO.DTO.UserDTO
            //{
            //    userID = 1,
            //    userName = "admin",
            //    password = "admin",
            //    roleID = 1
            //};

            //// Tạo đơn hàng mới
            //var invoice = new InvoiceDTO
            //{
            //    UserID = AppSession.CurrentUser.userID,
            //    CreatedDate = DateTime.Now,
            //    TotalAmount = Convert.ToDecimal(lblTotal.Text.Replace(" ₫", "").Replace(".", "")),
            //    Status = "Pending",
            //    InvoiceDetails = new List<InvoiceDetailDTO>()
            //};

            //// Thêm các chi tiết hóa đơn từ DataGridView vào Invoice
            //foreach(DataGridViewRow row in invoiceDataGridView.Rows)
            //{
            //    if(row.Cells["ProductID"].Value != null)
            //    {
            //        var invoiceDetail = new InvoiceDetailDTO
            //        {
            //            ProductID = Convert.ToInt32(row.Cells["ProductID"].Value),
            //            Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
            //            UnitPrice = Convert.ToDecimal(row.Cells["Price"].Value),
            //            LineTotal = Convert.ToDecimal(row.Cells["Total"].Value),
            //        };
            //        invoice.InvoiceDetails.Add(invoiceDetail);
            //    }
            //}

            //// Mở form thanh toán
            //using (var paymentForm = new PaymentForm(invoice))
            //{
            //    if(paymentForm.ShowDialog() == DialogResult.OK)
            //    {
            //        invoiceDataGridView.Rows.Clear();
            //        UpdateCartTotal();
            //        if (!DesignMode)
            //        {
            //            LoadProducts();
            //        }
            //    }
            //}
        }
    }
}
