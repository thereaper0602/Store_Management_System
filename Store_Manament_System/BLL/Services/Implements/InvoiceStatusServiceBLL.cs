using DAL.Repository;
using DAL.Repository.Implements;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Implements
{
    public class InvoiceStatusServiceBLL : IInvoiceStatusServiceBLL
    {
        private readonly IInvoiceStatusRepositoryDAL invoiceStatusRepositoryDAL = new InvoiceStatusRepositoryDAL();

        public List<InvoiceStatusDTO> GetAllInvoiceStatuses()
        {
            return invoiceStatusRepositoryDAL.GetAllInvoiceStatuses()
                .Select(status => new InvoiceStatusDTO
                {
                    InvoiceStatusID = status.StatusID,
                    InvoiceStatusName = status.StatusName
                })
                .ToList();
        }
    }
}
