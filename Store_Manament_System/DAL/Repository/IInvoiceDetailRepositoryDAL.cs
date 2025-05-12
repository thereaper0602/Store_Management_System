using DAL.Model;

namespace DAL.Repository
{
    public interface IInvoiceDetailRepositoryDAL
    {
        void AddInvoiceDetails(InvoiceDetail invoiceDetails);
    }
}