using BCrypt.Net;
using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.Repository
{
    // LoginDAL
    public class LoginDAL
    {
        // Khởi tạo đối tượng db để kết nối với cơ sở dữ liệu thông qua Entity Framework
        private StoreContext db = new StoreContext();

        // Phương thức Login nhận vào tên người dùng và mật khẩu để kiểm tra đăng nhập
        public User Login(string username, string password)
        {
            // Tìm người dùng trong cơ sở dữ liệu
            var user = db.Users.FirstOrDefault(u => u.Username == username);
            // Nếu tìm thấy user và mật khẩu đúng (kiểm tra bằng BCrypt)
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password)) 
            {
                // Tạo và trả về đối tượng UserDTO chứa các thông tin cần thiết của người dùng
                return user;
            }
            // Nếu không tìm thấy người dùng, trả về null
            return null;
        }
    }

}
