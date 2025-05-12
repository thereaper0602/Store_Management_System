using DTO.DTO;

namespace BLL.Services
{
    public interface ILoginBLL
    {
        UserDTO Login(string username, string password);
    }
}