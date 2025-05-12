using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IUserRoleServiceBLL
    {
        List<UserRoleDTO> GetAllUserRoles();
    }
}