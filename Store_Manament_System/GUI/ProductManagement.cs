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
using DTO.DTO;
using System.IO;
using System.Security.Cryptography;
using BLL;

namespace GUI
{
    public partial class ProductManagement: UserControl
    {
        private readonly ProductService prodService;
        private List<ProductDTO> products;
        private ProductDTO currentProduct = new ProductDTO();
        private ImageServiceBLL imageService = new ImageServiceBLL();
        public ProductManagement()
        {
            InitializeComponent();
            prodService = new ProductService();
            loadColumn();
            loadCategoryComboBox();
            searchLoader.Visible = false;
        }

        private void clearForm()
        {
            productNameTxt.Clear();
            productDescriptionTxt.Clear();
            categoryComboBox.SelectedItem = null;
            productStockTxt.Clear();
            productPriceTxt.Clear();
            productExpiryDatePicker.Value = DateTime.Now;
            productBarCodeTxt.Clear();
            productPicturebox.Image = null;
        }

        private void loadCategoryComboBox()
        {
            // Assuming you have a method to get categories
            List<int> categories = new List<int> { 1, 2, 3 };
            categoryComboBox.DataSource = categories;
            //categoryComboBox.ValueMember = "id"; // Assuming the category has an 'id' property
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
            clearForm();
            currentProduct.id = 0;
            products = prodService.GetAllProducts(null);
            productDataGridView.DataSource = products;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            currentProduct.id = 0;
            clearForm();
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var selectedRow = productDataGridView.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                currentProduct = prodService.GetProductById(id);
                if (currentProduct != null)
                {
                    productNameTxt.Text = currentProduct.name;
                    productDescriptionTxt.Text = currentProduct.description;
                    categoryComboBox.SelectedItem = currentProduct.categoryID;
                    productStockTxt.Text = currentProduct.stockQuantity.ToString();
                    productPriceTxt.Text = currentProduct.price.ToString();
                    productExpiryDatePicker.Value = currentProduct.expiryDate;
                    productBarCodeTxt.Text = currentProduct.barcode;

                    ImageDTO image = imageService.GetImageById(currentProduct.imageID);

                    if (image != null && File.Exists(image.imagePath)) {
                        using (var stream = new FileStream(image.imagePath, FileMode.Open, FileAccess.Read))
                        {
                            productPicturebox.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        productPicturebox.Image = null;
                    }
                }
            }
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchTxtBox.Text.Trim();

            searchLoader.Visible = true;
            searchLoader.BringToFront();

            search_pro.Enabled = false;

            // Perform the search in a separate thread
            var searchResult = await Task.Run(() => prodService.GetAllProducts(keyword));

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
            if (currentProduct.id == 0)
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
                    name = productNameTxt.Text,
                    description = productDescriptionTxt.Text,
                    categoryID = Convert.ToInt32(categoryComboBox.SelectedItem),
                    stockQuantity = Convert.ToInt32(productStockTxt.Text),
                    price = Convert.ToDecimal(productPriceTxt.Text),
                    expiryDate = productExpiryDatePicker.Value,
                    barcode = productBarCodeTxt.Text,
                    imageID = 1 // Set default image ID or handle image upload
                };
                bool result = prodService.AddProduct(newProduct,imageDTO);
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
                currentProduct.name = productNameTxt.Text;
                currentProduct.description = productDescriptionTxt.Text;
                currentProduct.categoryID = Convert.ToInt32(categoryComboBox.SelectedItem);
                currentProduct.stockQuantity = Convert.ToInt32(productStockTxt.Text);
                currentProduct.price = Convert.ToDecimal(productPriceTxt.Text);
                currentProduct.expiryDate = productExpiryDatePicker.Value;
                currentProduct.barcode = productBarCodeTxt.Text;

                if (productPicturebox.Image != null)
                {
                    ImageDTO oldImage = imageService.GetImageById(currentProduct.imageID);

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
                    imageService.UpdateImage(oldImage); // Bạn cần có hàm này trong ImageServiceBLL
                }

                bool result = prodService.UpdateProduct(currentProduct);
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
            if (currentProduct.id != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool deleteResult = prodService.DeleteProduct(currentProduct.id);
                    if (deleteResult)
                    {
                        MessageBox.Show("Successfully deleted product");
                        loadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product");
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void uploadProductImageBtn_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    productPicturebox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
