using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class ProductPromotionDTO
    {
        public int productPromotionID { get; set; }
        public int? productID { get; set; }
        public int? promotionID { get; set; }
    }
}
