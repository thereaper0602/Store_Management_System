using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTO.DTO;
using DAL.Repository;
using System.Text.RegularExpressions;
using System.IO;


namespace BLL.Services
{
    // đổi internal thành public vào class EmployeeService
    public class EmployeeServiceBLL : IEmployeeServiceBLL
    {
        private readonly UserRepositoryDAL personal = new UserRepositoryDAL();
        private readonly StoreContext _context = new StoreContext();
        private readonly ImageRepositoryDAL imageRepositoryDAL = new ImageRepositoryDAL();

        private readonly UserWorkShiftRepositoryDAL userWorkShift = new UserWorkShiftRepositoryDAL();
        private readonly WorkShiftRepositoryDAL workShiftRepository = new WorkShiftRepositoryDAL();

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

        public List<UserDTO> GetAllUser()
        {
            return personal.GetAllUser()
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
                .ToList();
        }

        public UserDTO GetUserById(int userId)
        {
            var user = personal.GetUserById(userId);
            if (user == null)
            {
                return null;
            }
            return new UserDTO
            {
                userID = user.UserID,
                fullName = user.FullName,
                gender = user.Gender,
                userName = user.Username,
                password = user.Password,
                roleID = user.RoleID ?? 0,
                phoneNumber = user.PhoneNumber,
                email = user.Email,
                hireDate = user.HireDate,
                imageID = user.ImageID ?? 0
            };
        }

        public bool AddUser(UserDTO userDTO, ImageDTO imageDTO)
        {
            if (userDTO == null || imageDTO == null)
            {
                return false;
            }

            ValidateUser(userDTO, imageDTO, false);

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Thêm ảnh mới
                    var image = new Image
                    {
                        ImageName = imageDTO.imageName,
                        ImagePath = imageDTO.imagePath,
                        UploadDate = DateTime.Now
                    };
                    var savedImage = imageRepositoryDAL.AddImage(image);
                    if (savedImage == null)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    // Tạo user mới
                    var user = new User
                    {
                        FullName = userDTO.fullName,
                        Gender = userDTO.gender,
                        Username = userDTO.userName,
                        Password = BCrypt.Net.BCrypt.HashPassword(userDTO.password),
                        RoleID = userDTO.roleID,
                        Email = userDTO.email,
                        PhoneNumber = userDTO.phoneNumber,
                        HireDate = userDTO.hireDate,
                        ImageID = savedImage.ImageID
                    };

                    personal.AddUser(user);
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Lỗi khi thêm người dùng: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateUser(UserDTO userDTO)
        {
            if (userDTO == null)
            {
                return false;
            }

            try
            {
                var existingUser = personal.GetUserById(userDTO.userID);
                if (existingUser == null)
                {
                    return false;
                }

                ValidateUser(userDTO, new ImageDTO { imagePath = "dummy" }, true);

                var user = new User
                {
                    UserID = userDTO.userID,
                    FullName = userDTO.fullName,
                    Gender = userDTO.gender,
                    Username = userDTO.userName,
                    Password = !string.IsNullOrEmpty(userDTO.password)
                        ? BCrypt.Net.BCrypt.HashPassword(userDTO.password)
                        : existingUser.Password,
                    RoleID = userDTO.roleID,
                    Email = userDTO.email,
                    PhoneNumber = userDTO.phoneNumber,
                    HireDate = userDTO.hireDate,
                    ImageID = userDTO.imageID
                };
                return personal.UpdateUser(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating user: {ex.Message}");
                return false;
            }
        }

        public bool DeleteUser(int userId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var result = personal.DeleteUser(userId);
                    if (!result)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine($"Error deleting user: {ex.Message}");
                    return false;
                }
            }
        }

        public bool DeleteUsers(List<int> userIds)
        {
            if (userIds == null || !userIds.Any())
            {
                return false;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var result = personal.DeleteUsers(userIds);
                    if (!result)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine($"Error deleting users: {ex.Message}");
                    return false;
                }
            }
        }
        public List<UserDTO> SearchUsers(string keyword)
        {
            try
            {
                var users = personal.SearchUser(keyword ?? "");

                return users.Select(u => new UserDTO
                {
                    userID = u.UserID,
                    fullName = u.FullName,
                    gender = u.Gender,
                    userName = u.Username,
                    password = u.Password,
                    roleID = u.RoleID ?? 0, // Explicitly handle nullable int  
                    email = u.Email,
                    phoneNumber = u.PhoneNumber,
                    hireDate = u.HireDate,
                    imageID = u.ImageID ?? 0 // Explicitly handle nullable int
                }).ToList();
            }
            catch (Exception ex)
            {
                return new List<UserDTO>();
                throw ex;
            }
        }

        //Xử lý cho tabPageWorkShift
        //phương thức lấy danh sách ca làm việc
        public List<UserWorkShiftDTO> GetAllUserWorkShift()
        {
            try
            {
                var shifts = userWorkShift.GetAllUserWorkShifts(); // Trả về List<UserWorkShift> từ DAL

                return shifts.Select(uws => new UserWorkShiftDTO
                {
                    userID = uws.UserID ?? 0,
                    fullName = uws.User?.FullName ?? "N/A",    // Giả sử bạn đã include User
                    gender = uws.User?.Gender ?? "N/A",
                    workShiftName = uws.WorkShift?.WorkShiftName ?? "N/A", // Giả sử bạn đã include WorkShift
                    workDate = uws.WorkDate
                }).ToList();
            }
            catch
            {
                return new List<UserWorkShiftDTO>();
            }
        }


        //Kiểm tra userID hợp hệ và là nhân viên
        public bool IsValidUserWithRole(int userId)
        {
            try
            {
                return personal.IsValidUserWithRole(userId);
            }
            catch
            {
                return false;
            }
        }


        //Lấy tên của dựa trên userID
        public string GetFullNameByUserId(int userId)
        {
            try
            {
                return personal.GetFullNameByUserId(userId);
            }
            catch
            {
                return "N/A";
            }
        }


        //thêm giờ làm việc cho nhân viên
        public bool AddUserWorkShift(UserWorkShiftDTO dto)
        {
            try
            {
                var entity = new UserWorkShift
                {
                    UserID = dto.userID,
                    WorkShiftID = dto.workShiftID,
                    WorkDate = dto.workDate
                };

                return userWorkShift.AddUserWorkShift(entity);
            }
            catch
            {
                return false;
            }
        }


        public bool HasWorkShiftOnDate(int userId, DateTime workDate)
        {
            try
            {
                return userWorkShift.HasWorkShiftOnDate(userId, workDate);
            }
            catch
            {
                return false;
            }
        }


        //Tính lương theo tháng cho nhân viên 
        //TabPageSalary
        public List<SalaryDTO> GetSalariesByMonthAndYear(int month, int year)
        {
            // Lấy danh sách nhân viên có RoleID = 2
            var users = personal.GetAllUsersWithRole(2);

            // Lấy tất cả các ca làm việc trong tháng và năm
            var workShifts = workShiftRepository.GetAllWorkShifts();

            // Lấy thông tin ca làm việc của người dùng trong tháng và năm
            var userWorkShifts = userWorkShift.GetUserWorkShiftsByMonthAndYear(month, year);

            // Tính toán lương cho từng người dùng
            var salaries = users.Select(user =>
            {
                // Lấy ca làm việc của nhân viên này trong tháng và năm
                var userShifts = userWorkShifts
                    .Where(uws => uws.UserID == user.UserID)
                    .ToList();

                // Tính số ca làm việc của từng ca
                int morningShifts = userShifts.Count(uws => uws.WorkShiftID == 1);
                int afternoonShifts = userShifts.Count(uws => uws.WorkShiftID == 2);
                int eveningShifts = userShifts.Count(uws => uws.WorkShiftID == 3);

                // Lấy lương theo ca làm việc
                decimal morningSalary = workShifts.FirstOrDefault(ws => ws.WorkShiftID == 1)?.WorkShiftSalary ?? 0;
                decimal afternoonSalary = workShifts.FirstOrDefault(ws => ws.WorkShiftID == 2)?.WorkShiftSalary ?? 0;
                decimal eveningSalary = workShifts.FirstOrDefault(ws => ws.WorkShiftID == 3)?.WorkShiftSalary ?? 0;

                // Tính tổng lương
                decimal totalSalary = (morningShifts * morningSalary * 8) +
                                      (afternoonShifts * afternoonSalary * 8) +
                                      (eveningShifts * eveningSalary * 8);

                // Tạo đối tượng SalaryDTO
                return new SalaryDTO
                {
                    userID = user.UserID,
                    fullName = user.FullName,  // Lấy fullName từ đối tượng user
                    gender = user.Gender,     // Lấy gender từ đối tượng user
                    morningShifts = morningShifts,
                    afternoonShifts = afternoonShifts,
                    eveningShifts = eveningShifts,
                    salary = totalSalary
                };
            }).ToList();

            return salaries;
        }

        List<EmployeeSalaryDTO> IEmployeeServiceBLL.GetSalaryEachWorkShiftThisMonth(int userId)
        {
            return userWorkShift.GetSalaryEachWorkShiftThisMonth(userId);
        }
    }
}
