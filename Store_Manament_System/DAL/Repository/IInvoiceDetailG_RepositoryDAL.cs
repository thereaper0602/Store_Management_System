using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IInvoiceDetailG_RepositoryDAL
    {
        List<InvoiceDetail> GetDetailsByInvoiceID(int invoiceID);
    }
}