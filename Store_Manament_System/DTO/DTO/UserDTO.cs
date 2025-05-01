using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class UserDTO
    {
        public int userID { get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public int roleID { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public DateTime hireDate { get; set; }

        public int imageID { get; set; }
    }
}

