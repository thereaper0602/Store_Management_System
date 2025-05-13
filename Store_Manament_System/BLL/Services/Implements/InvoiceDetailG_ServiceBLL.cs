// BLL - InvoiceDetailG_ServiceBLL
using DAL.Repository;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class InvoiceDetailG_ServiceBLL : IInvoiceDetailG_ServiceBLL
    {

        private readonly InvoiceDetailG_RepositoryDAL _detailDAL = new InvoiceDetailG_RepositoryDAL();
        // Lấy danh sách chi tiết hóa đơn theo invoice 
        public List<InvoiceDetailDTO> GetDetailsByInvoiceID(int invoiceID)
        {
            var details = _detailDAL.GetDetailsByInvoiceID(invoiceID);
            var detailDTOs = details.Select(d => new InvoiceDetailDTO
            {
                DetailID = d.DetailID,
                InvoiceID = d.InvoiceID,
                ProductID = d.ProductID,
                Quantity = d.Quantity,
                UnitPrice = d.UnitPrice,
                LineTotal = d.LineTotal
            }).ToList();

            return detailDTOs;
        }
    }
}


