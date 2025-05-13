using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implements
{
    public class InvoiceStatusRepositoryDAL : IInvoiceStatusRepositoryDAL
    {
        public List<InvoiceStatus> GetAllInvoiceStatuses()
        {
            using (var context = new StoreContext())
            {
                return context.InvoiceStatus.ToList();
            }
        }
    }
}
