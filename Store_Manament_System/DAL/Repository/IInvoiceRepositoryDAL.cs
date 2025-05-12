using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IInvoiceRepositoryDAL
    {
        int AddInvoice(Invoice invoice);
        List<Invoice> GetAllInvoices();
        Invoice GetInvoiceById(int invoiceId);
    }
}