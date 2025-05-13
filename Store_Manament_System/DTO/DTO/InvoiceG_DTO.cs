using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class InvoiceG_DTO
    {
        public int InvoiceID { get; set; }
        public int? UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Change { get; set; }
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public List<InvoiceDetailG_DTO> InvoiceDetails { get; set; } = new List<InvoiceDetailG_DTO>();
    }

}


