using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class EmployeeSalaryDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal Salary { get; set; }
        public DateTime WorkDate { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string TotalPrice { get; set; }
    }
}
