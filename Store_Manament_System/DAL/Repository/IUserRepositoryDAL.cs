using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IUserRepositoryDAL
    {
        User AddUser(User user);
        bool DeleteUser(int userId);
        bool DeleteUsers(List<int> userIds);
        List<User> GetAllUser();
        List<User> GetAllUsersWithRole(int roleId);
        string GetFullNameByUserId(int userId);
        User GetUserById(int id);
        List<User> GetUsersByIds(List<int> userIds);
        bool IsValidUserWithRole(int userId);
        List<User> SearchUser(string kw);
        bool UpdateUser(User user);
    }
}