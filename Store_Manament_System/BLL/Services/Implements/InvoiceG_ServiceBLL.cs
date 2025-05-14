
// BLL Layer
using DAL.Repository;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BLL.Services
{
    public class InvoiceG_ServiceBLL : IInvoiceG_ServiceBLL
    {
        private readonly InvoiceG_RepositoryDAL _invoiceDAL = new InvoiceG_RepositoryDAL();
        private readonly InvoiceDetailG_RepositoryDAL _detailDAL = new InvoiceDetailG_RepositoryDAL();

        // Lấy danh sách hóa đơn
        public List<InvoiceG_DTO> GetAllInvoices(int userId)
        {
            var invoices = _invoiceDAL.GetAllInvoices().Where(u => u.UserID.Equals(userId));
            return invoices.Select(i => new InvoiceG_DTO
            {
                InvoiceID = i.InvoiceID,
                UserID = i.UserID,
                CreatedDate = i.CreatedDate,
                TotalPrice = i.TotalPrice,
                Change = i.Change ?? 0,
                StatusID = i.StatusID ?? 0,
                StatusName = i.InvoiceStatus?.StatusName ?? "",
                //InvoiceDetails = _detailDAL.GetDetailsByInvoiceID(i.InvoiceID).Select(d => new InvoiceDetailG_DTO
                //{
                //    DetailID = d.DetailID,
                //    InvoiceID = d.InvoiceID,
                //    ProductID = d.ProductID,
                //    Quantity = d.Quantity,
                //    UnitPrice = d.UnitPrice,
                //    LineTotal = d.LineTotal
                //}).ToList()
            }).ToList();
        }

        // Lấy danh sách trạng thái hóa đơn
        public List<InvoiceG_DTO> GetAllStatuses()
        {
            return _invoiceDAL.GetAllStatuses().Select(s => new InvoiceG_DTO
            {
                StatusID = s.StatusID,
                StatusName = s.StatusName
            }).ToList();
        }
        // Xóa hóa đơn bằng ID
        public bool DeleteInvoice(int invoiceID)
        {
            return _invoiceDAL.DeleteInvoice(invoiceID);
        }
        // Tìm kiếm hóa đơn theo từ khóa
        public List<InvoiceG_DTO> SearchInvoices(string keyword)
        {
            var invoices = _invoiceDAL.SearchInvoices(keyword);
            return invoices.Select(i => new InvoiceG_DTO
            {
                InvoiceID = i.InvoiceID,
                UserID = i.UserID,
                CreatedDate = i.CreatedDate,
                TotalPrice = i.TotalPrice,
                Change = i.Change ?? 0,
                StatusID = i.StatusID ?? 0,
                StatusName = i.InvoiceStatus?.StatusName ?? "",
                //InvoiceDetails = _detailDAL.GetDetailsByInvoiceID(i.InvoiceID).Select(d => new InvoiceDetailG_DTO
                //{
                //    DetailID = d.DetailID,
                //    InvoiceID = d.InvoiceID,
                //    ProductID = d.ProductID,
                //    Quantity = d.Quantity,
                //    UnitPrice = d.UnitPrice,
                //    LineTotal = d.LineTotal
                //}).ToList()
            }).ToList();
        }
        // Lọc hóa đơn theo trạng thái
        public List<InvoiceG_DTO> GetInvoicesByStatus(string statusName)
        {
            var invoices = _invoiceDAL.GetInvoicesByStatus(statusName);
            return invoices.Select(i => new InvoiceG_DTO
            {
                InvoiceID = i.InvoiceID,
                UserID = i.UserID,
                CreatedDate = i.CreatedDate,
                TotalPrice = i.TotalPrice,
                Change = i.Change ?? 0,
                StatusID = i.StatusID ?? 0,
                StatusName = i.InvoiceStatus?.StatusName ?? "",
                //InvoiceDetails = _detailDAL.GetDetailsByInvoiceID(i.InvoiceID).Select(d => new InvoiceDetailG_DTO
                //{
                //    DetailID = d.DetailID,
                //    InvoiceID = d.InvoiceID,
                //    ProductID = d.ProductID,
                //    Quantity = d.Quantity,
                //    UnitPrice = d.UnitPrice,
                //    LineTotal = d.LineTotal
                //}).ToList()
            }).ToList();
        }
        // Lọc hóa đơn theo từ khóa, khoảng ngày và trạng thái
        public List<InvoiceG_DTO> FilterInvoices(string keyword, DateTime? fromDate, DateTime? toDate, string statusName)
        {
            var invoices = _invoiceDAL.FilterInvoices(keyword, fromDate, toDate, statusName);

            var invoiceDTOs = invoices.Select(i => new InvoiceG_DTO
            {
                InvoiceID = i.InvoiceID,
                UserID = i.UserID,
                CreatedDate = i.CreatedDate,
                TotalPrice = i.TotalPrice,
                Change = i.Change ?? 0m,
                StatusID = i.StatusID ?? 0,
                StatusName = i.InvoiceStatus?.StatusName ?? "Unknown",
                InvoiceDetails = _detailDAL.GetDetailsByInvoiceID(i.InvoiceID).
                Select(d => new InvoiceDetailG_DTO
                {
                    DetailID = d.DetailID,
                    InvoiceID = d.InvoiceID,
                    ProductID = d.ProductID,
                    Quantity = d.Quantity,
                    UnitPrice = d.UnitPrice,
                    LineTotal = d.LineTotal
                }).ToList()
            }).ToList();

            return invoiceDTOs;
        }

        public List<InvoiceG_DTO> GetInvoicesByStatus(int statusId, int userId)
        {
            if(statusId == 0)
            {
                var invoices = _invoiceDAL.GetAllInvoices().Where(u => u.UserID.Equals(userId));
                return invoices.Select(i => new InvoiceG_DTO
                {
                    InvoiceID = i.InvoiceID,
                    UserID = i.UserID,
                    CreatedDate = i.CreatedDate,
                    TotalPrice = i.TotalPrice,
                    Change = i.Change ?? 0,
                    StatusID = i.StatusID ?? 0,
                    StatusName = i.InvoiceStatus?.StatusName ?? "",
                }).ToList();
            }
            else
            {
                var invoices = _invoiceDAL.GetAllInvoices().Where(u => u.UserID.Equals(userId));
                return invoices.Select(i => new InvoiceG_DTO
                {
                    InvoiceID = i.InvoiceID,
                    UserID = i.UserID,
                    CreatedDate = i.CreatedDate,
                    TotalPrice = i.TotalPrice,
                    Change = i.Change ?? 0,
                    StatusID = i.StatusID ?? 0,
                    StatusName = i.InvoiceStatus?.StatusName ?? "",
                }).ToList();
            }
        }
    }
}


