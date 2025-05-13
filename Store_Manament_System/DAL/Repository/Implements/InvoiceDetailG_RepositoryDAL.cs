
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class InvoiceDetailG_RepositoryDAL : IInvoiceDetailG_RepositoryDAL
    {
        private readonly StoreContext db = new StoreContext();

        // Lấy chi tiết hóa đơn theo InvoiceID 
        public List<InvoiceDetail> GetDetailsByInvoiceID(int invoiceID)
        {
            return db.InvoiceDetails
                .Where(d => d.InvoiceID == invoiceID)
                .ToList();
        }
    }
}



