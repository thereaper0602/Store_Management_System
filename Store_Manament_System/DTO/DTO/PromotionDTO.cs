using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    //Thêm public thay cho internal
    public class PromotionDTO
    {
        public int promotionID { get; set; }
        public string promotionName { get; set; }
        public decimal discountRate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string description { get; set; }

    }
}
