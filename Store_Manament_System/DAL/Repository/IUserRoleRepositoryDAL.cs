using DTO.DTO;
using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IUserRoleRepositoryDAL
    {
        List<UserRole> GetAllUserRoles();
    }
}