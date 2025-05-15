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
using DTO.DTO;
using System.IO;
using System.Security.Cryptography;
using BLL;
using System.Drawing.Drawing2D;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing;
using GUI.Utils;

namespace GUI
{
    public partial class ProductManagement : UserControl, IRefreshable
    {
        private readonly IProductService _prodService = new ProductService();
        private List<ProductDTO> products;
        private ProductDTO currentProduct = new ProductDTO();
        private readonly IImageServiceBLL _imageService = new ImageServiceBLL();
        private readonly ICategoryBLL _categoryBLL = new CategoryBLL();
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void loadInitData()
        {
            loadColumn();
            //if (!DesignMode)
            //{
            //    loadProducts();
            //    loadCategoryComboBox();
            //}
        }

        private void clearForm()
        {
            productNameTxt.Clear();
            productDescriptionTxt.Clear();
            categoryComboBox.SelectedItem = null;
            productPriceTxt.Clear();
            productPicturebox.Image = null;
            productDataGridView.ClearSelection();
        }

        private void loadCategoryComboBox()
        {
            categoryComboBox.DataSource = null;
            categoryComboBox.Items.Clear();
            // Assuming you have a methodto get categories
            List<CategoryDTO> categories = _categoryBLL.GetAllCategories();
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "CategoryName"; // Tên thuộc tính hiển thị
            categoryComboBox.ValueMember = "CategoryID";     // Tên thuộc tính giá trị

            // Đặt SelectedItem = null để không chọn mặc định
            categoryComboBox.SelectedItem = null;
        }

        private void loadColumn()
        {
            productDataGridView.AutoGenerateColumns = false;

            productDataGridView.Columns.Clear();

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductID",
                HeaderText = "ID",
                Width = 20,
                ReadOnly = true
            });

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product name",
                Width = 200,
                ReadOnly = true
            });

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Width = 200,
                ReadOnly = true
            });

            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoryID",
                HeaderText = "Category ID",
                Width = 20,
                ReadOnly = true
            });


            productDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price",
                Width = 50,
                ReadOnly = true
            });

        }

        public void loadProducts()
        {
            productDataGridView.DataSource = null;
            //clearForm();
            currentProduct.ProductID = 0;
            products = _prodService.GetAllProducts("");
            productDataGridView.DataSource = products;
            productDataGridView.Refresh();
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            currentProduct.ProductID = 0;
            productDataGridView.ClearSelection();
            clearForm();
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = productDataGridView.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                currentProduct = _prodService.GetProductById(id);
                if (currentProduct != null)
                {
                    productNameTxt.Text = currentProduct.ProductName;
                    productDescriptionTxt.Text = currentProduct.Description;
                    categoryComboBox.SelectedValue = currentProduct.CategoryID;
                    productPriceTxt.Text = currentProduct.Price.ToString();

                    ImageDTO image = _imageService.GetImageById((int)currentProduct.ImageID);

                    if (image != null && File.Exists(image.imagePath))
                    {
                        using (var stream = new FileStream(image.imagePath, FileMode.Open, FileAccess.Read))
                        {
                            var tempImage = Image.FromStream(stream);
                            productPicturebox.Image = new Bitmap(tempImage); // Copy để giải phóng stream
                        }
                    }
                    else
                    {
                        productPicturebox.Image = null;
                    }

                }
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

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchTxtBox.Text.Trim();

            searchLoader.Visible = true;
            searchLoader.BringToFront();

            search_pro.Enabled = false;

            // Perform the search in a separate thread
            var searchResult = await Task.Run(() => _prodService.GetAllProducts(keyword));

            if (searchResult != null && searchResult.Count > 0)
            {
                productDataGridView.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("No products found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            searchLoader.Visible = false;
            search_pro.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(productNameTxt.Text))
            {
                MessageBox.Show("Please enter product's name");
                return;
            }

            if (String.IsNullOrEmpty(productPriceTxt.Text))
            {
                MessageBox.Show("Please enter product's price");
                return;
            }

            decimal price;
            if (!decimal.TryParse(productPriceTxt.Text, out price))
            {
                MessageBox.Show("Product price must be a valid number");
                return;
            }

            if (categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a category");
                return;
            }

            if ((int)currentProduct.ProductID == 0)
            {
                // Add new product
                string imageName = Guid.NewGuid().ToString() + ".jpg";
                string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Images\Products");
                string imagePath = Path.Combine(imageFolder, imageName);
                if (!Directory.Exists(imageFolder))
                {
                    Directory.CreateDirectory(imageFolder);
                }

                if (productPicturebox.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn ảnh cho sản phẩm.");
                    return;
                }

                productPicturebox.Image.Save(imagePath);

                ImageDTO imageDTO = new ImageDTO
                {
                    imageName = imageName,
                    imagePath = imagePath
                };


                ProductDTO newProduct = new ProductDTO
                {
                    ProductName = productNameTxt.Text,
                    Description = productDescriptionTxt.Text,
                    CategoryID = (int)categoryComboBox.SelectedValue,
                    Price = Convert.ToDecimal(productPriceTxt.Text),
                    ImageID = 1 // Set default image ID or handle image upload
                };
                bool result = _prodService.AddProduct(newProduct, imageDTO);
                if (result)
                {
                    MessageBox.Show("Succesfully add new Product");
                    loadProducts(); // làm mới lại danh sách nếu cần
                }
                else
                {
                    MessageBox.Show("Failed to add product");
                }
            }
            else
            {
                // Update existing product
                currentProduct.ProductName = productNameTxt.Text;
                currentProduct.Description = productDescriptionTxt.Text;
                currentProduct.CategoryID = (int)categoryComboBox.SelectedValue;
                currentProduct.Price = Convert.ToDecimal(productPriceTxt.Text);

                if (productPicturebox.Image != null)
                {
                    ImageDTO oldImage = _imageService.GetImageById((int)currentProduct.ImageID);

                    // Nếu ảnh cũ tồn tại => xóa file ảnh cũ
                    if (oldImage != null && File.Exists(oldImage.imagePath))
                    {
                        File.Delete(oldImage.imagePath);
                    }

                    // Tạo tên và đường dẫn mới
                    string imageName = Guid.NewGuid().ToString() + ".jpg";
                    string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Images\Products");
                    string imagePath = Path.Combine(imageFolder, imageName);
                    if (!Directory.Exists(imageFolder))
                    {
                        Directory.CreateDirectory(imageFolder);
                    }

                    // Lưu ảnh mới
                    productPicturebox.Image.Save(imagePath);

                    // Cập nhật lại thông tin ảnh trong DB
                    oldImage.imageName = imageName;
                    oldImage.imagePath = imagePath;
                    _imageService.UpdateImage(oldImage); // Bạn cần có hàm này trong _imageServiceBLL
                }

                bool result = _prodService.UpdateProduct(currentProduct);
                if (result)
                {
                    MessageBox.Show("Successfully updated product");
                }
                else
                {
                    MessageBox.Show("Failed to update product");
                }
                loadProducts();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (currentProduct.ProductID != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool deleteResult = _prodService.DeleteProduct(currentProduct.ProductID);
                    if (deleteResult)
                    {
                        MessageBox.Show("Successfully deleted product");
                        loadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product");
                    }
                    loadProducts();
                    clearForm();
                    currentProduct = new ProductDTO();
                }
            }
            else
            {
                return;
            }
        }

        private void uploadProductImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    productPicturebox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                loadInitData();
            }
            searchLoader.Visible = false;
        }

        public new void Refresh()
        {
            productDataGridView.DataSource = null;
            currentProduct.ProductID = 0;
            productDataGridView.ClearSelection();
            clearForm();
            searchTxtBox.Clear();
            searchLoader.Visible = false;
            search_pro.Enabled = true;
            loadProducts();
            loadCategoryComboBox();
        }

    }
}
