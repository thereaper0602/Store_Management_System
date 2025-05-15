using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DAL.Repository
{
    public class InvoiceG_RepositoryDAL : IInvoiceG_RepositoryDAL
    {
        // Khởi tạo DbContext để thao tác với cơ sở dữ liệu
        private readonly StoreContext db = new StoreContext();

        // Lấy toàn bộ danh sách hóa đơn (Invoice),
        // bao gồm cả trạng thái hóa đơn (InvoiceStatus)
        public List<Invoice> GetAllInvoices()
        {
            var existingEntities = db.ChangeTracker.Entries<Invoice>().ToList();
            foreach (var entry in existingEntities)
            {
                entry.State = System.Data.Entity.EntityState.Detached;
            }
            return db.Invoices.AsNoTracking().ToList();
        }
        // Lấy toàn bộ danh sách trạng thái hóa đơn
        public List<InvoiceStatus> GetAllStatuses()
        {
            return db.InvoiceStatus.ToList();
        }
        // Tìm kiếm hóa đơn theo keyword nhập vào 
        public List<Invoice> SearchInvoices(string keyword)
        {
            return db.Invoices.Include("InvoiceStatus").ToList()
                .Where(i =>
                    i.InvoiceID.ToString().Contains(keyword) ||
                    (i.UserID != null && i.UserID.ToString().Contains(keyword)) ||
                    i.CreatedDate.ToString("dd/MM/yyyy").Contains(keyword) ||
                    (i.TotalPrice != null && i.TotalPrice.ToString().Contains(keyword)) ||
                    (i.Change != null && i.Change.ToString().Contains(keyword)) ||
                    (i.InvoiceStatus.StatusName != null && i.InvoiceStatus.StatusName.Contains(keyword))
                ).ToList();
        }
        // Lọc danh sách hóa đơn theo trạng thái cụ thể
        public List<Invoice> GetInvoicesByStatus(string statusName)
        {
            return db.Invoices.Include("InvoiceStatus")
                .Where(i => i.InvoiceStatus.StatusName.ToLower() == statusName.ToLower())
                .ToList();
        }
        // Xóa hóa đơn theo ID, đồng thời xóa chi tiết hóa đơn liên quan
        public bool DeleteInvoice(int invoiceID)
        {
            var invoice = db.Invoices.Find(invoiceID);
            if (invoice != null)
            {
                db.InvoiceDetails.RemoveRange(db.InvoiceDetails.Where(d => d.InvoiceID == invoiceID));
                db.Invoices.Remove(invoice);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // Lọc hóa đơn
        public List<Invoice> FilterInvoices(string keyword, DateTime? fromDate, DateTime? toDate, string statusName)
        {
            var query = db.Invoices
                          .Join(db.InvoiceStatus, i => i.StatusID, s => s.StatusID, (i, s) => new { i, s })
                          .AsQueryable();

            // Lọc theo từ khóa (nếu có)
            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.Trim().ToLower();
                query = query.Where(x =>
                    x.i.InvoiceID.ToString().Contains(keyword) ||
                    (x.i.UserID != null && x.i.UserID.ToString().Contains(keyword)) ||
                    x.i.CreatedDate.ToString("dd/MM/yyyy").ToLower().Contains(keyword) ||
                    (x.i.TotalPrice != null && x.i.TotalPrice.ToString().Contains(keyword)) ||
                    (x.i.Change != null && x.i.Change.Value.ToString().Contains(keyword)) ||
                    x.s.StatusName.ToLower().Contains(keyword)
                );
            }

            // Lọc theo khoảng thời gian (nếu có)
            if (fromDate.HasValue && toDate.HasValue)
            {
                query = query.Where(x =>
                    x.i.CreatedDate >= fromDate.Value && x.i.CreatedDate <= toDate.Value
                );
            }

            // Lọc theo trạng thái (nếu có)
            if (!string.IsNullOrEmpty(statusName) && statusName != "All Status...")
            {
                query = query.Where(x =>
                    x.s.StatusName.ToLower().Equals(statusName.ToLower())
                );
            }
            // Trả kq: sắp xếp theo ngày tạo giảm dần, chỉ lấy hóa đơn
            return query.OrderByDescending(x => x.i.CreatedDate).Select(x => x.i).ToList();
        }

        public List<Invoice> GetInvoicesByStatus(int statusID)
        {
            // Lấy danh sách hóa đơn theo trạng thái
            return db.Invoices
                .Where(i => i.StatusID == statusID)
                .ToList();
        }
    }
}


