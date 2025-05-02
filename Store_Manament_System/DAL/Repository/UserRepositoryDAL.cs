using System;
using System.Collections.Generic;
//sử lý đường dẫn ảnh 
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DTO.DTO;


namespace DAL.Repository
{
    public class UserRepositoryDAL
    {

        private readonly StoreContext personal = new StoreContext();

        // Phương thức lấy tất cả người dùng
        public List<UserDTO> GetAllUser()
        {
            return personal.Users
                .Select(e => new UserDTO()
                {
                    userID = e.UserID,
                    fullName = e.FullName,
                    gender = e.Gender,
                    userName = e.Username,
                    password = e.Password,
                    roleID = e.RoleID ?? 0,
                    phoneNumber = e.PhoneNumber,
                    email = e.Email,
                    hireDate = e.HireDate,
                    imageID = e.ImageID ?? 0
                })
                .ToList();
        }

        //Phương thức lấy người dùng theo ID
        public UserDTO GetUserById(int userId)
        {
            try
            {
                var user = personal.Users
                    .Where(u => u.UserID == userId)
                    .Select(e => new UserDTO
                    {
                        userID = e.UserID,
                        fullName = e.FullName,
                        gender = e.Gender,
                        userName = e.Username,
                        password = e.Password,
                        roleID = e.RoleID ?? 0,
                        phoneNumber = e.PhoneNumber,
                        email = e.Email,
                        hireDate = e.HireDate,
                        imageID = e.ImageID ?? 0
                    })
                    .FirstOrDefault();

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddUser(ImageDTO imageDTO, UserDTO userDTO)
        {
            using (var transaction = personal.Database.BeginTransaction())
            {
                try
                {
                    // Thêm ảnh mới và lấy ID
                    var image = new Image
                    {
                        ImageName = imageDTO.imageName,
                        ImagePath = imageDTO.imagePath,
                        UploadDate = DateTime.Now
                    };
                    personal.Images.Add(image);
                    personal.SaveChanges(); // Lưu để có được ImageID

                    int newImageId = image.ImageID;

                    // Gán ImageID cho nhân viên
                    var newUser = new User
                    {
                        FullName = userDTO.fullName,
                        Gender = userDTO.gender,
                        Username = userDTO.userName,
                        Password = userDTO.password,
                        RoleID = userDTO.roleID,
                        Email = userDTO.email,
                        PhoneNumber = userDTO.phoneNumber,
                        HireDate = userDTO.hireDate,
                        ImageID = newImageId // Sử dụng newImageId thay vì userDTO.imageID
                    };

                    personal.Users.Add(newUser);
                    personal.SaveChanges();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    // Hiển thị lỗi chi tiết để debug
                    throw ex;
                }
            }
        }


        //Phuong thuc cap nhat nhan vien
        public bool UpdateUser(UserDTO userDTO)
        {
            //using (var transaction = personal.Database.BeginTransaction())
            //{
                try
                {
                    // Corrected the issue by using the instance of userDTO instead of the class name
                    var user = personal.Users.FirstOrDefault(u => u.UserID == userDTO.userID);
                    if (user == null) // Fixed the null check to verify the user entity
                    {
                        return false;
                    }

                    // Update the user properties
                    user.FullName = userDTO.fullName;
                    user.Gender = userDTO.gender;
                    user.Username = userDTO.userName;
                    user.Password = userDTO.password;
                    user.RoleID = userDTO.roleID;
                    user.Email = userDTO.email;
                    user.PhoneNumber = userDTO.phoneNumber;
                    user.HireDate = userDTO.hireDate;
                    user.ImageID = userDTO.imageID;

                    personal.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    // Log the error or display a message
                    
                    return false;
                    throw ex;
                }
            //}
        }

        // Phương thức xóa một nhân viên dựa trên UserID
        public bool DeleteUser(int userId, ImageDTO imageDTO)
        {
            using (var transaction = personal.Database.BeginTransaction())
            {
                try
                {
                    // Bước 1: Tìm và xóa nhân viên từ bảng Users
                    var employee = personal.Users.FirstOrDefault(e => e.UserID == userId);
                    if (employee == null)
                    {
                        return false; // Không tìm thấy nhân viên
                    }

                    // Lấy ImageID trước khi xóa nhân viên
                    int? imageId = employee.ImageID;

                    // Xóa nhân viên
                    personal.Users.Remove(employee);
                    personal.SaveChanges();

                    // Bước 2: Xóa ảnh từ bảng Images nếu có ImageID
                    if (imageId.HasValue && imageId > 0)
                    {
                        var image = personal.Images.FirstOrDefault(i => i.ImageID == imageId);
                        if (image != null)
                        {
                            personal.Images.Remove(image);
                            personal.SaveChanges();
                        }
                    }

                    // Bước 3: Xóa file ảnh từ thư mục nếu imageDTO.imagePath tồn tại
                    if (imageDTO != null && !string.IsNullOrEmpty(imageDTO.imagePath) && File.Exists(imageDTO.imagePath))
                    {
                        File.Delete(imageDTO.imagePath);
                    }

                    // Commit transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }


        // Phương thức xóa nhiều nhân viên dựa trên danh sách UserID
        public bool DeleteUsers(List<int> userIds)
        {
            using (var transaction = personal.Database.BeginTransaction())
            {
                try
                {
                    // Bước 1: Tìm danh sách nhân viên cần xóa
                    var employees = personal.Users.Where(e => userIds.Contains(e.UserID)).ToList();
                    if (employees == null || employees.Count == 0)
                    {
                        return false; // Không tìm thấy nhân viên nào
                    }

                    // Lưu danh sách ImageID trước khi xóa nhân viên
                    var imageIds = employees
                        .Where(e => e.ImageID.HasValue && e.ImageID > 0)
                        .Select(e => e.ImageID.Value)
                        .ToList();

                    // Lấy danh sách ImageDTO để xóa file ảnh
                    var images = personal.Images
                        .Where(i => imageIds.Contains(i.ImageID))
                        .Select(i => new ImageDTO
                        {
                            imageID = i.ImageID,
                            imageName = i.ImageName,
                            imagePath = i.ImagePath
                        })
                        .ToList();

                    // Bước 2: Xóa danh sách nhân viên từ bảng Users
                    personal.Users.RemoveRange(employees);
                    personal.SaveChanges();

                    // Bước 3: Xóa các ảnh liên quan từ bảng Images
                    if (imageIds.Any())
                    {
                        var imagesToDelete = personal.Images.Where(i => imageIds.Contains(i.ImageID)).ToList();
                        personal.Images.RemoveRange(imagesToDelete);
                        personal.SaveChanges();
                    }

                    // Bước 4: Xóa các file ảnh từ thư mục
                    foreach (var imageDto in images)
                    {
                        if (!string.IsNullOrEmpty(imageDto.imagePath) && File.Exists(imageDto.imagePath))
                        {
                            try
                            {
                                File.Delete(imageDto.imagePath);
                            }
                            catch (Exception fileEx)
                            {
                                // Log lỗi nếu cần, nhưng không làm gián đoạn quá trình xóa
                                throw fileEx;
                            }
                        }
                    }

                    // Commit transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public List<UserDTO> SearchUsers(string keyword)
        {
            // Nếu từ khóa trống, trả về toàn bộ danh sách
            if (string.IsNullOrEmpty(keyword))
            {
                return GetAllUser();
            }

            // Chuyển từ khóa thành chữ thường để tìm kiếm không phân biệt hoa thường
            keyword = keyword.ToLower();

            var allUsers = GetAllUser();


            // Chỉ tìm kiếm theo promotionID và promotionName
            return allUsers
                .Where(u =>
                    u.userID.ToString().Contains(keyword) ||
                    (u.fullName != null && u.fullName.ToLower().Contains(keyword))
                )
                .ToList();
        }


        //Cho bảng tabPage WorkShift
        // Kiểm tra UserID có tồn tại và có RoleID = 2 không
        public bool IsValidUserWithRole(int userId)
        {
            var user = personal.Users
                .Where(u => u.UserID == userId && u.RoleID == 2)
                .FirstOrDefault();
            return user != null;
        }

        // Lấy FullName dựa trên UserID
        public string GetFullNameByUserId(int userId)
        {
            var user = personal.Users
                .Where(u => u.UserID == userId)
                .Select(u => u.FullName)
                .FirstOrDefault();
            return user ?? "No found";
        }

        


    }
}
