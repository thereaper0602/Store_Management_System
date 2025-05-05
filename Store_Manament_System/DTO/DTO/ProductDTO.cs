using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int? CategoryID { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? ImageID { get; set; }
    }
}
