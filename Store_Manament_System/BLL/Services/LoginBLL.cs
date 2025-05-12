using DAL.Model;
using DAL.Repository;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    // Lớp LoginBLL xử lý các nghiệp vụ liên quan đến đăng nhập
    public class LoginBLL
    {
        private LoginDAL dal = new LoginDAL();  // Khởi tạo đối tượng LoginDAL để truy cập vào DAL

        // Phương thức Login nhận vào tên đăng nhập và mật khẩu và trả về đối tượng UserDTO
        public UserDTO Login(string username, string password)
        {
            // Gọi phương thức Login trong DAL để kiểm tra đăng nhập và trả về thông tin người dùng nếu đăng nhập thành công
            User user = dal.Login(username, password);
            if (user != null)
            {
                // Chuyển đổi đối tượng User thành UserDTO
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
            // Nếu không tìm thấy người dùng, trả về null
            return null;
        }
    }
}
