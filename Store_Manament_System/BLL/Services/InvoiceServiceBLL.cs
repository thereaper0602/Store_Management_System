using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.DTO;
using DAL.Model;

namespace BLL.Services
{
    public class InvoiceServiceBLL
    {
        private readonly InvoiceRepositoryDAL _invoiceRepositoryDAL = new InvoiceRepositoryDAL();
        private readonly InvoiceDetailRepositoryDAL invoiceDetailRepositoryDAL = new InvoiceDetailRepositoryDAL();
        private readonly ProductRepositoryDAL _productRepositoryDAL = new ProductRepositoryDAL();
        private readonly StoreContext _context = new StoreContext();

        public List<InvoiceDTO> GetAllInvoices()
        {
            var invoices = _invoiceRepositoryDAL.GetAllInvoices();
            return invoices.Select(i => new InvoiceDTO
            {
                InvoiceID = i.InvoiceID,
                UserID = i.UserID,
                CreatedDate = i.CreatedDate,
                TotalAmount = i.TotalAmount,
                Status = i.Status,
                InvoiceDetails = i.InvoiceDetails.Select(d => new InvoiceDetailDTO
                {
                    DetailID = d.DetailID,
                    ProductID = d.ProductID,
                    Quantity = d.Quantity,
                    UnitPrice = d.UnitPrice,
                    LineTotal = d.LineTotal
                }).ToList()
            }).ToList();
        }

        public InvoiceDTO GetInvoiceById(int invoiceId)
        {
            var invoice = _invoiceRepositoryDAL.GetInvoiceById(invoiceId);
            if (invoice == null) return null;
            return new InvoiceDTO
            {
                InvoiceID = invoice.InvoiceID,
                UserID = invoice.UserID,
                CreatedDate = invoice.CreatedDate,
                TotalAmount = invoice.TotalAmount,
                Status = invoice.Status,
                InvoiceDetails = invoice.InvoiceDetails.Select(d => new InvoiceDetailDTO
                {
                    DetailID = d.DetailID,
                    ProductID = d.ProductID,
                    Quantity = d.Quantity,
                    UnitPrice = d.UnitPrice,
                    LineTotal = d.LineTotal
                }).ToList()
            };
        }

        public int CreateInvoice(InvoiceDTO invoiceDTO)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Tạo hóa đơn mới
                    var invoice = new Invoice
                    {
                        UserID = invoiceDTO.UserID,
                        CreatedDate = invoiceDTO.CreatedDate,
                        TotalAmount = invoiceDTO.TotalAmount,
                        Status = invoiceDTO.Status
                    };

                    int invoiceID = _invoiceRepositoryDAL.AddInvoice(invoice);

                    // Thêm chi tiết hóa đơn
                    foreach (var detail in invoiceDTO.InvoiceDetails)
                    {
                        var product = _productRepositoryDAL.GetProductById((int)detail.ProductID);
                        if (product == null)
                        {
                            throw new Exception($"Product ID {detail.ProductID} not found");
                        }

                        if (product.StockQuantity < 0)
                        {
                            throw new Exception($"Not enough stock for Product ID {detail.ProductID}");
                        }
                        var invoiceDetail = new InvoiceDetail
                        {
                            InvoiceID = invoice.InvoiceID,
                            ProductID = detail.ProductID,
                            Quantity = detail.Quantity,
                            UnitPrice = detail.UnitPrice,
                            LineTotal = detail.LineTotal
                        };

                        // Thêm chi tiết hóa đơn vào cơ sở dữ liệu
                        invoiceDetailRepositoryDAL.AddInvoiceDetails(invoiceDetail);

                        // Cập nhật số lượng sản phẩm trong kho
                        product.StockQuantity -= detail.Quantity;
                        _productRepositoryDAL.UpdateProduct(product);
                    }
                    _context.SaveChanges();
                    transaction.Commit();
                    return invoice.InvoiceID;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Invoice creation failed. " + ex.Message);
                }
            }
        }
    }
}
