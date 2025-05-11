using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DAL.Repository;
using DTO.DTO;
//using BCrypt.Net;

namespace BLL.Services
{
    // đổi internal thành public vào class EmployeeService
    public class EmployeeServiceBLL
    {
        private readonly UserRepositoryDAL user = new UserRepositoryDAL();

        private readonly UserWorkShiftRepositoryDAL userWorkShift = new UserWorkShiftRepositoryDAL();

        private readonly SalaryRepositoryDAL _salaryRepository = new SalaryRepositoryDAL();

        
        //phương thức lấy danh sách nhân viên
        public List<UserDTO> GetAllUser()
        {
            return user.GetAllUser();
        }
        private void ValidateUser(UserDTO user, ImageDTO image, bool isUpdate)
        {
           
            // Username
            if (string.IsNullOrEmpty(user.userName))
                throw new Exception("Please enter the username!");
            if (user.userName.Contains(" "))
                throw new Exception("Username cannot contain spaces!");
            if (user.userName.Length < 6 || user.userName.Length > 20)
                throw new Exception("Username must be between 6 and 20 characters!");
            if (!Regex.IsMatch(user.userName, @"^[a-zA-Z0-9]+$"))
                throw new Exception("Username cannot contain accented or special characters!");

            // Password (required if not an update)
            if (!isUpdate || !string.IsNullOrEmpty(user.password))
            {
                if (string.IsNullOrEmpty(user.password))
                    throw new Exception("Please enter the password!");
                if (user.password.Contains(" "))
                    throw new Exception("Password cannot contain spaces!");
                if (user.password.Length < 8 || user.password.Length > 20)
                    throw new Exception("Password must be between 8 and 20 characters!");
                if (!Regex.IsMatch(user.password, @"^[a-zA-Z0-9!@#$%^&*]+$"))
                    throw new Exception("Password cannot contain accented characters!");
                if (!Regex.IsMatch(user.password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*]).+$"))
                    throw new Exception("Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character (!@#$%^&*)!");
            }

            // Email
            if (!string.IsNullOrEmpty(user.email))
            {
                if (user.email.Contains(" "))
                    throw new Exception("Email cannot contain spaces!");
                if (!Regex.IsMatch(user.email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
                    throw new Exception("Invalid email format! Email must be in the format xxx@gmail.com");
            }

            // Phone
            if (!string.IsNullOrEmpty(user.phoneNumber))
            {
                if (user.phoneNumber.Contains(" "))
                    throw new Exception("Phone number cannot contain spaces!");
                if (!Regex.IsMatch(user.phoneNumber, @"^0\d{9}$"))
                    throw new Exception("Phone number must be 10 digits and start with 0!");
            }

            // Image validation (required for new users, optional for updates if not updated)
            if (!isUpdate && image == null)
            {
                throw new Exception("Please select an image for the user.");
            }
        }

       
        public bool AddUser(ImageDTO imageDTO, UserDTO employeeDTO)
        {
            try
            {
                ValidateUser(employeeDTO, imageDTO, false);

                if (!string.IsNullOrEmpty(employeeDTO.password))
                {
                    employeeDTO.password = BCrypt.Net.BCrypt.HashPassword(employeeDTO.password);
                }

                return user.AddUser(imageDTO, employeeDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateUser(UserDTO employeeDTO)
        {
            try
            {
                var existingUser = user.GetUserById(employeeDTO.userID);
                if (existingUser == null)
                {
                    throw new Exception("No found!");
                }

                // Optional: bạn có thể kiểm tra ảnh có tồn tại nếu cần cập nhật
                ValidateUser(employeeDTO, new ImageDTO { imagePath = "dummy" }, true);

                if (!string.IsNullOrEmpty(employeeDTO.password) && employeeDTO.password != existingUser.password)
                {
                    employeeDTO.password = BCrypt.Net.BCrypt.HashPassword(employeeDTO.password);
                }
                else
                {
                    employeeDTO.password = existingUser.password;
                }

                return user.UpdateUser(employeeDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




// Phương thức xóa một nhân viên dựa trên UserID
    public bool DeleteUser(int userId, ImageDTO imageDTO)
        {
            return user.DeleteUser(userId, imageDTO);
        }

        // Phương thức xóa nhiều nhân viên dựa trên danh sách UserID
        public bool DeleteUsers(List<int> userIds)
        {
            return user.DeleteUsers(userIds);
        }
        //phuương thức tìm kiếm nhân viên
        public List<UserDTO> SearchUser(string searchTerm)
        {
            return user.SearchUsers (searchTerm);
        }

        //Xử lý cho tabPageWorkShift
        //phương thức lấy danh sách ca làm việc
        public List<UserWorkShiftDTO> GetAllUserWorkShift()
        {
            return userWorkShift.GetAllUserWorkShift();
        }
        
        //Kiểm tra userID hợp hệ và là nhân viên
        public bool IsValidUserWithRole(int userId)
        {
            return user.IsValidUserWithRole(userId);
        }

        //Lấy tên của dựa trên userID
        public string GetFullNameByUserId(int userId)
        {
            return user.GetFullNameByUserId(userId);
        }

        //thêm giờ làm việc cho nhân viên
        public bool AddUserWorkShift(UserWorkShiftDTO userWorkShiftDto)
        {
            return userWorkShift.AddUserWorkShift(userWorkShiftDto);
        }

        public bool HasWorkShiftOnDate(int userId, DateTime workDate)
        {
            return userWorkShift.HasWorkShiftOnDate(userId, workDate);
        }

        //Tính lương theo tháng cho nhân viên 
        //TabPageSalary
        public List<SalaryDTO> GetSalariesByMonthAndYear(int month, int year)
        {
            return _salaryRepository.GetSalariesByMonthAndYear(month, year);
        }  

    }
}

