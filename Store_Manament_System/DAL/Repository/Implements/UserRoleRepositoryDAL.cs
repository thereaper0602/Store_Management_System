using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Model;
using DTO.DTO;

namespace DAL.Repository
{
    public class UserRoleRepositoryDAL : IUserRoleRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();
        public List<UserRoleDTO> GetAllUserRoles()
        {
            return _context.UserRoles
                .Select(e => new UserRoleDTO()
                {
                    roleID = e.RoleID,
                    roleName = e.RoleName
                })
                .ToList();
        }

    }
}
