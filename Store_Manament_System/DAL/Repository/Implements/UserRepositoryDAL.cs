using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

//sử lý đường dẫn ảnh 
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL.Model;
using DTO.DTO;

namespace DAL.Repository
{
    public class UserRepositoryDAL : IUserRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();

        //phương thức lấy danh sách nhân viên
        public List<User> GetAllUser()
        {
            var existingEntities = _context.ChangeTracker.Entries<User>().ToList();
            foreach (var entry in existingEntities)
            {
                entry.State = System.Data.Entity.EntityState.Detached;
            }
            return _context.Users.AsNoTracking().ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public List<User> GetUsersByIds(List<int> userIds)
        {
            return _context.Users.Where(u => userIds.Contains(u.UserID)).ToList();
        }

        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }


        public bool UpdateUser(User user)
        {
            try
            {
                var existingUser = _context.Users.FirstOrDefault(u => u.UserID == user.UserID);
                if (existingUser == null)
                {
                    return false;
                }

                existingUser.Username = user.Username;
                existingUser.Password = user.Password;
                existingUser.FullName = user.FullName;
                existingUser.Gender = user.Gender;
                existingUser.RoleID = user.RoleID;
                existingUser.PhoneNumber = user.PhoneNumber;
                existingUser.Email = user.Email;
                existingUser.HireDate = user.HireDate;
                existingUser.ImageID = user.ImageID;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating user: {ex.Message}");
                throw;
            }
        }

        public bool DeleteUser(int userId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var user = _context.Users.FirstOrDefault(u => u.UserID == userId);
                    if (user == null)
                    {
                        return false;
                    }

                    var imageId = user.ImageID;
                    string imagePath = null;

                    if (imageId.HasValue)
                    {
                        var image = _context.Images.FirstOrDefault(i => i.ImageID == imageId);
                        if (image != null)
                        {
                            imagePath = image.ImagePath;
                            _context.Images.Remove(image);
                        }
                    }

                    _context.Users.Remove(user);
                    _context.SaveChanges();

                    // Delete physical image file after database operations
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        try
                        {
                            File.Delete(imagePath);
                        }
                        catch (IOException ex)
                        {
                            Console.WriteLine($"Warning: Could not delete image file {imagePath}: {ex.Message}");
                        }
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
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var users = _context.Users.Where(u => userIds.Contains(u.UserID)).ToList();
                    if (!users.Any())
                    {
                        return false;
                    }

                    var imageIds = users.Where(u => u.ImageID.HasValue)
                                       .Select(u => u.ImageID.Value)
                                       .ToList();
                    var imagePaths = new List<string>();

                    if (imageIds.Any())
                    {
                        var images = _context.Images.Where(i => imageIds.Contains(i.ImageID)).ToList();
                        imagePaths = images.Select(i => i.ImagePath).Where(p => !string.IsNullOrEmpty(p)).ToList();
                        _context.Images.RemoveRange(images);
                    }

                    _context.Users.RemoveRange(users);
                    _context.SaveChanges();

                    // Delete physical image files
                    foreach (var imagePath in imagePaths)
                    {
                        if (File.Exists(imagePath))
                        {
                            try
                            {
                                File.Delete(imagePath);
                            }
                            catch (IOException ex)
                            {
                                Console.WriteLine($"Warning: Could not delete image file {imagePath}: {ex.Message}");
                            }
                        }
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


        //phuương thức tìm kiếm nhân viên
        public List<User> SearchUser(string kw)
        {
            try
            {
                var users = _context.Users.AsQueryable();

                if (!string.IsNullOrEmpty(kw))
                {
                    kw = kw.ToLower();
                    users = users.Where(u =>
                        u.UserID.ToString().Contains(kw) ||
                        (u.FullName != null && u.FullName.ToLower().Contains(kw)));
                }

                return users.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<User> GetAllUsersWithRole(int roleId)
        {
            try
            {
                // Truy vấn tất cả người dùng có RoleID = roleId
                return _context.Users
                    .Where(u => u.RoleID == roleId)  // Lọc theo RoleID
                    .ToList();  // Trả về danh sách người dùng
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có
                throw new Exception("Error while fetching users with specified role.", ex);
            }
        }

        public bool IsValidUserWithRole(int userId)
        {
            return _context.Users.Any(u => u.UserID == userId && u.RoleID == 2);
        }

        public string GetFullNameByUserId(int userId)
        {
            return _context.Users
                .FirstOrDefault(u => u.UserID == userId)?.FullName ?? "No found";
        }
    }
}