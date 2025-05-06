using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class StockDTO
    {
        public int stockID { get; set; }
        public int? productID { get; set; }
        public string productName { get; set; }
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public decimal cost { get; set; }
        public int stockQuantity { get; set; }
        public DateTime? importDate { get; set; }
        public DateTime? expiryDate { get; set; }

        public int totalQuantity { get; set; }
    }
}
