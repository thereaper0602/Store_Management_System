using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class ProductRevenueDTO
    {
        public String ProductName { get; set; }
        public decimal TotalRevenue { get; set; }
        public int TotalQuantitySold { get; set; }
    }
}
