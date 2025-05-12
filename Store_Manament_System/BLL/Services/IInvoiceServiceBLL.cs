using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IInvoiceServiceBLL
    {
        int CreateInvoice(InvoiceDTO invoiceDTO);
        List<InvoiceDTO> GetAllInvoices();
        InvoiceDTO GetInvoiceById(int invoiceId);
    }
}