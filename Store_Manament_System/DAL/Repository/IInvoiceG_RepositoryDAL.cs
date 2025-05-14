using DAL.Model;
using System;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IInvoiceG_RepositoryDAL
    {
        bool DeleteInvoice(int invoiceID);
        List<Invoice> FilterInvoices(string keyword, DateTime? fromDate, DateTime? toDate, string statusName);
        List<Invoice> GetAllInvoices();
        List<InvoiceStatus> GetAllStatuses();
        List<Invoice> GetInvoicesByStatus(string statusName);
        List<Invoice> SearchInvoices(string keyword);
    }
}