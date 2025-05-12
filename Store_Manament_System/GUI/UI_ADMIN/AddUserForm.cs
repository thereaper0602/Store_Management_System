using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL.Services;
using DTO.DTO;
using Image = System.Drawing.Image;
using System.IO;
using System.Text.RegularExpressions;


namespace GUI
{
    public partial class AddUserForm : Form
    {
        private readonly IEmployeeServiceBLL _employeeService;
        private UserDTO _employeeToEdit;
        private bool _isEditMode;
        private readonly IImageServiceBLL _imageService = new ImageServiceBLL();
        // Flag to track if a new image was uploaded
        private bool _isImageUpdated = false; 


        // Constructor cho chế độ thêm mới
        public AddUserForm()
        {
            InitializeComponent();
            _employeeService = new EmployeeServiceBLL();
            _isEditMode = false;
            LoadUserRoles();
            HireDate.Value = DateTime.Now;

            // Đặt pcUser.Image thành null để tránh ảnh mặc định
            pcUser.Image = null;
        }

        // Constructor cho chế độ chỉnh sửa
        public AddUserForm(UserDTO employeeToEdit) : this()
        {
            _employeeToEdit = employeeToEdit;
            _isEditMode = true;
            LoadUserData();

            lbForm.Text = "Edit User";
            btAdd.Text = "Update";
        }

        private void LoadUserRoles()
        {
            try
            {
                UserRoleServiceBLL userRoleService = new UserRoleServiceBLL();
                List<UserRoleDTO> userRoles = userRoleService.GetAllUserRoles();
                if (userRoles != null && userRoles.Count > 0)
                {
                    cbUserRole.DataSource = userRoles;
                    cbUserRole.DisplayMember = "roleName";
                    cbUserRole.ValueMember = "roleID";
                }
                else
                {
                    MessageBox.Show("No roles found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when downloading the role list: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadUserData()
        {
            if (_employeeToEdit != null)
            {
                // Split name into First Name and Last Name
                string[] nameParts = _employeeToEdit.fullName.Split(new[] { ' ' }, 2);
                tbFirstName.Text = nameParts.Length > 0 ? nameParts[0] : "";
                tbLastName.Text = nameParts.Length > 1 ? nameParts[1] : "";

                // Set gender
                if (_employeeToEdit.gender == "Male")
                {
                    rdbMale.Checked = true;
                }
                else if (_employeeToEdit.gender == "Female")
                {
                    rdbFemale.Checked = true;
                }

                // Set other fields
                cbUserRole.SelectedValue = _employeeToEdit.roleID;
                tbLogin.Text = _employeeToEdit.userName;
                tbPassword.Text = ""; // Do not display old password
                tbEmail.Text = _employeeToEdit.email;
                tbPhone.Text = _employeeToEdit.phoneNumber;
                HireDate.Value = _employeeToEdit.hireDate;

                // Load image if ImageID exists
                try
                {
                    if (_employeeToEdit.imageID > 0)
                    {
                        var imageDto = _imageService.GetImageById(_employeeToEdit.imageID);
                        if (imageDto != null && File.Exists(imageDto.imagePath))
                        {
                            using (var tempImage = System.Drawing.Image.FromFile(imageDto.imagePath))
                            {
                                pcUser.Image = new System.Drawing.Bitmap(tempImage);
                            }
                        }
                        else
                        {
                            pcUser.Image = null;
                        }
                    }
                    else
                    {
                        pcUser.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pcUser.Image = null;
                }
            }
        }

        private void btAddPcUser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var image = Image.FromFile(ofd.FileName))
                        {
                            // Check image size (max 5MB)
                            FileInfo fileInfo = new FileInfo(ofd.FileName);
                            if (fileInfo.Length > 5 * 1024 * 1024)
                            {
                                MessageBox.Show("Photo size exceeds 5MB!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            pcUser.Image = new Bitmap(image);
                            _isImageUpdated = true; // Set flag to indicate a new image was uploaded
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pcUser.Image = null;
                        _isImageUpdated = false;
                    }
                }
            }
        }

        // Save image to disk and return the name and path

        private void SaveImage(string imageName, string imagePath)
        {
            string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Images\Users");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }

            pcUser.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }


        private (string imageName, string imagePath) GenerateImage()
        {
            string imageName = Guid.NewGuid().ToString() + ".jpg";
            string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Images\Users");
            string imagePath = Path.Combine(imageFolder, imageName);
            return (imageName, imagePath);
        }



        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string fullName = $"{tbFirstName.Text.Trim()} {tbLastName.Text.Trim()}".Trim();
                var employeeDto = _isEditMode ? _employeeToEdit : new UserDTO();
                employeeDto.fullName = fullName;
                employeeDto.gender = rdbMale.Checked ? "Male" : "Female";
                employeeDto.roleID = (int)cbUserRole.SelectedValue;
                employeeDto.userName = tbLogin.Text;
                employeeDto.password = tbPassword.Text;
                employeeDto.email = tbEmail.Text;
                employeeDto.phoneNumber = tbPhone.Text;
                employeeDto.hireDate = HireDate.Value;

                bool result;
                ImageDTO imageDto = null;

                if (_isEditMode)
                {
                    // Update existing user  
                    if (_isImageUpdated && pcUser.Image != null) // Only update image if a new one was uploaded  
                    {
                        // Retrieve existing image  
                        ImageDTO oldImage = _imageService.GetImageById(employeeDto.imageID);

                        // Delete old image file if it exists  
                        if (oldImage != null && File.Exists(oldImage.imagePath))
                        {
                            File.Delete(oldImage.imagePath);
                        }

                        // Save new image  
                        var (imageName, imagePath) = GenerateImage();

                        // Update or create image DTO  
                        if (oldImage != null)
                        {
                            oldImage.imageName = imageName;
                            oldImage.imagePath = imagePath;
                            _imageService.UpdateImage(oldImage);
                            imageDto = new ImageDTO
                            {
                                imageName = imageName,
                                imagePath = imagePath
                            };
                        }
                        else
                        {
                            imageDto = new ImageDTO
                            {
                                imageName = imageName,
                                imagePath = imagePath
                            };
                            employeeDto.imageID = _imageService.AddImage(imageDto).imageID;
                        }
                    }

                    result = _employeeService.UpdateUser(employeeDto);
                }
                else
                {
                    if (string.IsNullOrEmpty(tbFirstName.Text)&&string.IsNullOrEmpty(tbLastName.Text))
                    {
                        MessageBox.Show("Please enter FistName.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(tbLastName.Text))
                    {
                        MessageBox.Show("Please enter LastName.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Add new user  
                    if (pcUser.Image == null)
                    {
                        MessageBox.Show("Please select an image for the user.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var (imageName, imagePath) = GenerateImage();

                    imageDto = new ImageDTO
                    {
                        imageName = imageName,
                        imagePath = imagePath
                    };

                    result = _employeeService.AddUser(imageDto, employeeDto);
                }

                if (result)
                {
                    // Save image
                    if (imageDto != null)
                    {
                        SaveImage(imageDto.imageName, imageDto.imagePath);
                    }
                    
                    MessageBox.Show(_isEditMode ? "Successfully updated user!" : "Successfully added user!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(_isEditMode ? "Failed to update user!" : "Failed to add user!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}


        