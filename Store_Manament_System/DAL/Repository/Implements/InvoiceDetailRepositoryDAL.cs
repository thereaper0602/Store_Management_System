using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.Repository
{
    public class InvoiceDetailRepositoryDAL : IInvoiceDetailRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();

        public void AddInvoiceDetails(InvoiceDetail invoiceDetails)
        {
            _context.InvoiceDetails.Add(invoiceDetails);
            _context.SaveChanges();
        }
    }
}
