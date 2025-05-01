using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class InvoiceRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();

        public List<Invoice> GetAllInvoices()
        {
            return _context.Invoices.ToList();
        }

        public Invoice GetInvoiceById(int invoiceId)
        {
            return _context.Invoices.FirstOrDefault(i => i.InvoiceID == invoiceId);
        }

        public int AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
            return _context.SaveChanges();
        }

    }
}
