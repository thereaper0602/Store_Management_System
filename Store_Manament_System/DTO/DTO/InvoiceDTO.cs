using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class InvoiceDTO
    {
        public int InvoiceID { get; set; }
        public int? UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public List<InvoiceDetailDTO> InvoiceDetails { get; set; } = new List<InvoiceDetailDTO>();
    }
}
