using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class SalaryDTO
    {
        public int userID { get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }
        public int morningShifts { get; set; } // Số lần làm ca sáng
        public int afternoonShifts { get; set; } // Số lần làm ca chiều
        public int eveningShifts { get; set; } // Số lần làm ca tối
        public decimal salary { get; set; } // Tổng tiền lương

    }
}
