using DTO.DTO;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IUserRepositoryDAL
    {
        bool AddUser(ImageDTO imageDTO, UserDTO userDTO);
        bool DeleteUser(int userId, ImageDTO imageDTO);
        bool DeleteUsers(List<int> userIds);
        List<UserDTO> GetAllUser();
        string GetFullNameByUserId(int userId);
        UserDTO GetUserById(int userId);
        bool IsValidUserWithRole(int userId);
        List<UserDTO> SearchUsers(string keyword);
        bool UpdateUser(UserDTO userDTO);
    }
}