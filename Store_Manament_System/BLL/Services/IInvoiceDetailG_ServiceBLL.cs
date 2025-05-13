// BLL - InvoiceDetailG_ServiceBLL
using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IInvoiceDetailG_ServiceBLL
    {
        List<InvoiceDetailDTO> GetDetailsByInvoiceID(int invoiceID);
    }
}