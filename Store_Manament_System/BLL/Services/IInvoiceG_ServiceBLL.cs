using DTO.DTO;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IInvoiceG_ServiceBLL
    {
        bool DeleteInvoice(int invoiceID);
        List<InvoiceG_DTO> FilterInvoices(string keyword, DateTime? fromDate, DateTime? toDate, string statusName);
        List<InvoiceG_DTO> GetAllInvoices(int userId);
        List<InvoiceG_DTO> GetAllStatuses();
        List<InvoiceG_DTO> GetInvoicesByStatus(int statusId,int userId);
        List<InvoiceG_DTO> SearchInvoices(string keyword);
    }
}