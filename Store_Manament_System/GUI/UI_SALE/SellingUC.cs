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
using AForge;
using AForge.Video.DirectShow;
using ZXing;
using AForge.Video;

namespace GUI.UI_SALE
{
    public partial class SellingUC : UserControl
    {
        private readonly IProductService productService = new ProductService();
        private readonly IStockServiceBLL stockService = new StockServiceBLL();
        private readonly IPromotionServiceBLL promotionService = new PromotionServiceBLL();
        private readonly ICategoryBLL categoryService = new CategoryBLL();

        FilterInfoCollection filterInfoCollection; // Danh sách các thiết bị camera
        VideoCaptureDevice videoCaptureDevice; // Thiết bị camera đang sử dụng

        private bool isScanning = false;
        private DateTime lastScanTime = DateTime.MinValue;



        public SellingUC()
        {
            InitializeComponent();
            this.Disposed += SellingUC_Disposed;
        }


        private void SellingUC_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                InitializeDataGridView();
                LoadCategories();
                LoadProducts();
                InitializeCamera();
            }
        }

        private void InitializeCamera()
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                MessageBox.Show($"{filterInfoCollection[0].Name}");
                if (filterInfoCollection.Count == 0)
                {
                    MessageBox.Show("No camera found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing camera: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewFrameEventHandler(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                // Nếu đang trong quá trình quét hoặc mới quét gần đây thì bỏ qua
                if (isScanning || (DateTime.Now - lastScanTime).TotalSeconds < 1)
                    return;

                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                // Giải mã mã vạch
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmap);

                if (result != null)
                {
                    // Đánh dấu đang quét
                    isScanning = true;
                    lastScanTime = DateTime.Now;

                    this.Invoke(new MethodInvoker(delegate
                    {
                        string productCode = result.Text;
                        var product = productService.GetProductByProductCode(productCode);
                        if (product != null)
                        {
                            AddProductToInvoices(product);
                        }
                        else
                        {
                            MessageBox.Show("Product not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // Hiển thị hình ảnh
                        pictureBox1.Image = bitmap;

                        // Mở khóa sau khi xử lý xong
                        isScanning = false;
                    }));
                }
            }
            catch (Exception ex)
            {
                // Mở khóa nếu có lỗi
                isScanning = false;
                throw ex;
            }
        }

        private void SellingUC_Disposed(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice.NewFrame -= NewFrameEventHandler;
            }
        }



        public void LoadCategories()
        {
            List<CategoryDTO> categories = categoryService.GetAllCategories();
            categoryCb.Items.Clear();

            // Thêm mục "All categories" vào đầu danh sách
            categoryCb.Items.Add(new CategoryDTO { CategoryID = -1, CategoryName = "All categories" });

            // Thêm các danh mục khác
            foreach (var category in categories)
            {
                categoryCb.Items.Add(category);
            }

            // Thiết lập DisplayMember và ValueMember
            categoryCb.DisplayMember = "CategoryName";
            categoryCb.ValueMember = "CategoryID";

            // Chọn mục đầu tiên
            categoryCb.SelectedIndex = 0;
        }
        public void LoadProducts()
        {
            List<ProductDTO> productsToDisplay = productService.GetAvailableProducts(null, -1);
            ProductFlowLayoutPanel.Controls.Clear();
            foreach (var product in productsToDisplay)
            {
                var panel = CreateProductPanel(product);
                ProductFlowLayoutPanel.Controls.Add(panel);
            }
        }

        private BunifuShadowPanel CreateProductPanel(ProductDTO product)
        {
            var panel = new BunifuShadowPanel();
            panel.BorderColor = Color.WhiteSmoke;
            panel.BackColor = Color.Transparent;
            panel.BorderRadius = 20;
            panel.BorderThickness = 1;
            panel.FillStyle = BunifuShadowPanel.FillStyles.Solid;
            panel.ForeColor = Color.Black;
            panel.GradientMode = BunifuShadowPanel.GradientModes.Vertical;
            panel.Location = new System.Drawing.Point(260, 10);
            panel.Margin = new Padding(8, 0, 4, 4);
            panel.ShadowColor = Color.DarkGray;
            panel.ShadowDept = 2;
            panel.ShadowDepth = 5;
            panel.ShadowStyle = BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            panel.ShadowTopLeftVisible = false;
            panel.Size = new Size(200, 320);
            panel.Style = BunifuShadowPanel.BevelStyles.Flat;

            // PictureBox cho hình ảnh sản phẩm
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(150, 150);
            pictureBox.Location = new System.Drawing.Point(20, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageDTO image = LoadImageFromID((int)product.ImageID);
            if (image != null && File.Exists(image.imagePath))
            {
                using (var stream = new FileStream(image.imagePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox.Image = Image.FromStream(stream);
                }
            }
            panel.Controls.Add(pictureBox);

            // Label cho tên sản phẩm
            Label nameLabel = new Label();
            nameLabel.Text = product.ProductName;
            nameLabel.Font = new Font("Poppins", 10, FontStyle.Bold);
            nameLabel.AutoSize = false;
            nameLabel.Size = new Size(200, 25);
            nameLabel.Location = new System.Drawing.Point(10, 220);
            panel.Controls.Add(nameLabel);

            // Label cho giá sản phẩm
            Label priceLabel = new Label();
            priceLabel.Text = product.Price.ToString("N0") + " ₫";
            priceLabel.ForeColor = Color.DarkGreen;
            priceLabel.Font = new Font("Poppins", 10, FontStyle.Regular);
            priceLabel.AutoSize = false;
            priceLabel.Size = new Size(200, 25);
            priceLabel.Location = new System.Drawing.Point(10, 250);
            panel.Controls.Add(priceLabel);

            // Label cho khuyến mãi
            Label promotionLabel = new Label();
            var promotion = productService.GetNearestPromotionByProductId(product.ProductID);
            if (promotion != null)
            {
                promotionLabel.Text = $"Promotion: {(int)promotion.discountRate}% off";
                promotionLabel.ForeColor = Color.Red;
            }
            else
            {
                promotionLabel.Text = "No Promotion";
                promotionLabel.ForeColor = Color.Gray;
            }
            promotionLabel.Font = new Font("Poppins", 10, FontStyle.Regular);
            promotionLabel.AutoSize = false;
            promotionLabel.Size = new Size(200, 25);
            promotionLabel.Location = new System.Drawing.Point(10, 280);
            panel.Controls.Add(promotionLabel);

            // Button thêm vào giỏ hàng
            BunifuButton2 addButton = new BunifuButton2();
            addButton.Text = "Add";
            addButton.Font = new Font("Poppins", 10, FontStyle.Bold);
            addButton.ForeColor = Color.White;
            addButton.AutoRoundBorders = true;
            addButton.Size = new Size(120, 35);
            addButton.Location = new System.Drawing.Point(30, 180);
            addButton.Click += (sender, e) => AddProductToInvoices(product);
            panel.Controls.Add(addButton);
            return panel;
        }

        private ImageDTO LoadImageFromID(int id)
        {
            ImageServiceBLL imageService = new ImageServiceBLL();
            return imageService.GetImageById(id);
        }

        private void AddProductToInvoices(ProductDTO product)
        {
            var stock = stockService.GetClosestStockByProductID(product.ProductID);
            if (stock == null)
            {
                MessageBox.Show("Product not found in stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (stock.stockQuantity <= 0)
            {
                MessageBox.Show("Product is out of stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool productExists = false;
            foreach (DataGridViewRow row in invoiceDataGridView.Rows)
            {
                if (row.Cells["ProductID"].Value != null &&
                    Convert.ToInt32(row.Cells["ProductID"].Value) == product.ProductID)
                {


                    // Tăng số lượng lên 1
                    int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    // Kiểm tra số lượng sản phẩm trong kho
                    if (currentQuantity >= stock.stockQuantity)
                    {
                        MessageBox.Show("Not enough stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row.Cells["Quantity"].Value = currentQuantity + 1;

                    // Cập nhật tổng tiền
                    int discount = 0;
                    var promotion = productService.GetNearestPromotionByProductId(product.ProductID);
                    if (promotion != null)
                    {
                        discount = (int)promotion.promotionID;
                    }
                    decimal price = product.Price - (product.Price * discount / 100);
                    row.Cells["Total"].Value = (currentQuantity + 1) * price;
                    productExists = true;
                    break;
                }
            }
            if (!productExists)
            {
                int discount = 0;
                var promotion = productService.GetNearestPromotionByProductId(product.ProductID);
                if (promotion != null)
                {
                    discount = (int)promotion.promotionID;
                }
                // Thêm sản phẩm mới vào DataGridView
                invoiceDataGridView.Rows.Add(
                    product.ProductID,
                    product.ProductName,
                    promotion != null ? product.Price - (product.Price * discount / 100) : product.Price,
                    1,
                    promotion != null ? product.Price - (product.Price * discount / 100) : product.Price
                );
            }
            UpdateCartTotal();
        }

        private void UpdateCartTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in invoiceDataGridView.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            lblTotal.Text = total.ToString("N0") + " ₫";
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
            invoiceDataGridView.Columns["Quantity"].Width = 100;

            invoiceDataGridView.Columns.Add("Total", "Total");
            invoiceDataGridView.Columns["Total"].DefaultCellStyle.Format = "N0";
            invoiceDataGridView.Columns["Total"].ReadOnly = true;

            // Thêm nút xóa nếu cần
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.DefaultCellStyle.BackColor = Color.Red;
            invoiceDataGridView.Columns.Add(deleteButton);
            invoiceDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 8, FontStyle.Regular);

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
            // Kiểm tra giỏ hàng, không có thì báo lỗi
            if (invoiceDataGridView.Rows.Count - 1 == 0)
            {
                MessageBox.Show("Please add items before payment!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppSession.CurrentUser = new UserDTO
            {
                userID = 1
            };

            //Tạo đơn hàng mới
            var invoice = new InvoiceDTO
            {
                UserID = AppSession.CurrentUser.userID,
                CreatedDate = DateTime.Now,
                TotalPrice = Convert.ToDecimal(lblTotal.Text.Replace(" ₫", "").Replace(".", "")),
                StatusID = 1,
                InvoiceDetails = new List<InvoiceDetailDTO>()
            };

            //    // Thêm các chi tiết hóa đơn từ DataGridView vào Invoice
            foreach (DataGridViewRow row in invoiceDataGridView.Rows)
            {
                if (row.Cells["ProductID"].Value != null)
                {
                    var invoiceDetail = new InvoiceDetailDTO
                    {
                        ProductID = Convert.ToInt32(row.Cells["ProductID"].Value),
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                        UnitPrice = Convert.ToDecimal(row.Cells["Price"].Value),
                        LineTotal = Convert.ToDecimal(row.Cells["Total"].Value),
                    };
                    invoice.InvoiceDetails.Add(invoiceDetail);
                }
            }

            // Mở form thanh toán
            using (var paymentForm = new PaymentForm(invoice))
            {
                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    invoiceDataGridView.Rows.Clear();
                    UpdateCartTotal();
                    if (!DesignMode)
                    {
                        LoadProducts();
                        LoadCategories();
                    }
                }
            }
        }

        private void categoryCb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!DesignMode && categoryCb.SelectedItem != null)
            {
                var selectedCategory = (CategoryDTO)categoryCb.SelectedItem;
                int selectedCategoryId = selectedCategory.CategoryID;

                List<ProductDTO> productsToDisplay = productService.GetAvailableProducts(null, selectedCategoryId);
                ProductFlowLayoutPanel.Controls.Clear();

                foreach (var product in productsToDisplay)
                {
                    var panel = CreateProductPanel(product);
                    ProductFlowLayoutPanel.Controls.Add(panel);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchTxtBox.Text.Trim();
            if (!DesignMode && !string.IsNullOrEmpty(keyword))
            {
                List<ProductDTO> productsToDisplay = productService.GetAvailableProducts(keyword, -1);
                ProductFlowLayoutPanel.Controls.Clear();
                foreach (var product in productsToDisplay)
                {
                    var panel = CreateProductPanel(product);
                    ProductFlowLayoutPanel.Controls.Add(panel);
                }
            }
            else
            {
                LoadProducts();
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += NewFrameEventHandler;
            videoCaptureDevice.Start();
            MessageBox.Show("Camera started!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if(videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
                else
                {
                    videoCaptureDevice.Start();
                }
            }
        }
    }
}
