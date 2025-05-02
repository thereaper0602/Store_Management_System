using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class UserWorkShiftDTO
    {
        public int userWorkShiftID { get; set; }
        public int userID { get; set; }
        public int workShiftID { get; set; }
        public DateTime workDate { get; set; }

        public string fullName { get; set; } // Thêm FullName
        public string gender { get; set; }   // Thêm Gender

        public string workShiftName { get; set; }

    }
}
