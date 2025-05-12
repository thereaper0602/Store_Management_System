using DTO.DTO;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IUserRoleRepositoryDAL
    {
        List<UserRoleDTO> GetAllUserRoles();
    }
}