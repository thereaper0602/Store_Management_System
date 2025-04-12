using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class ProductDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int categoryID { get; set; }
        public int stockQuantity { get; set; }
        public decimal price { get; set; }
        public DateTime expiryDate { get; set; }
    }
}
