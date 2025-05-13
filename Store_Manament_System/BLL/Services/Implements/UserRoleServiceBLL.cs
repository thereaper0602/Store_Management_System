using DAL.Repository;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserRoleServiceBLL : IUserRoleServiceBLL
    {
        private readonly UserRoleRepositoryDAL user = new UserRoleRepositoryDAL();


        public List<UserRoleDTO> GetAllUserRoles()
        {
            return user.GetAllUserRoles()
                .Select(e => new UserRoleDTO()
                {
                    roleID = e.RoleID,
                    roleName = e.RoleName
                })
                .ToList();
        }
    }
}