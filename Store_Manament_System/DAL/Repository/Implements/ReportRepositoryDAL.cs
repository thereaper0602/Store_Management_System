using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ReportRepositoryDAL : IReportRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();

        // Lấy ra tổng số tiền đã nhập vào kho
        public int getTotalCostOfGoodsSoldToday()
        {
            DateTime today = DateTime.Today;
            //DateTime fromDate = today.AddDays(-7);
            var totalCost = (from stock in _context.Stocks
                             where DbFunctions.TruncateTime(stock.ImportDate) == today
                             select (int?)stock.Cost).Sum();
            return (totalCost ?? 0);
        }

        public int getTotalCostOfGoodsSoldThisWeek()
        {
            DateTime today = DateTime.Today;
            DateTime fromDate = today.AddDays(-7);
            var totalCost = (from stock in _context.Stocks
                             where DbFunctions.TruncateTime(stock.ImportDate) >= fromDate
                             select (int?)stock.Cost).Sum();
            return (totalCost ?? 0);
        }

        public int getTotalCostOfGoodsSoldThisMonth()
        {
            DateTime today = DateTime.Today;
            DateTime fromDate = new DateTime(today.Year, today.Month, 1);
            var totalCost = (from stock in _context.Stocks
                             where DbFunctions.TruncateTime(stock.ImportDate) >= fromDate
                             select (int?)stock.Cost).Sum();
            return (totalCost ?? 0);
        }

        public int getTotalCostOfGoodsSoldThisYear()
        {
            DateTime today = DateTime.Today;
            DateTime fromDate = new DateTime(today.Year, 1, 1);
            var totalCost = (from stock in _context.Stocks
                             where DbFunctions.TruncateTime(stock.ImportDate) >= fromDate
                             select (int?)stock.Cost).Sum();
            return (totalCost ?? 0);
        }


        public int getTotalProductsSoldToday()
        {
            DateTime today = DateTime.Today;
            var totalSold = (from detail in _context.InvoiceDetails
                             join invoice in _context.Invoices
                             on detail.InvoiceID equals invoice.InvoiceID
                             where DbFunctions.TruncateTime(invoice.CreatedDate) == today
                             select (int?)detail.Quantity).Sum();
            return totalSold ?? 0;
        }

        public int getTotalRevenueToday()
        {
            DateTime today = DateTime.Today;
            var totalRevenue = (from detail in _context.InvoiceDetails
                                join invoice in _context.Invoices
                                on detail.InvoiceID equals invoice.InvoiceID
                                where DbFunctions.TruncateTime(invoice.CreatedDate) == today
                                select (decimal?)detail.Quantity * detail.UnitPrice).Sum();
            return (int)(totalRevenue ?? 0);
        }

        public int getTotalProductsSoldThisMonth()
        {
            DateTime today = DateTime.Today;
            DateTime fromDate = new DateTime(today.Year, today.Month, 1);
            var totalSold = (from detail in _context.InvoiceDetails
                             join invoice in _context.Invoices
                             on detail.InvoiceID equals invoice.InvoiceID
                             where DbFunctions.TruncateTime(invoice.CreatedDate) >= fromDate
                             select (int?)detail.Quantity).Sum();
            return totalSold ?? 0;
        }

        public int getTotalRevenueThisMonth()
        {
            DateTime today = DateTime.Today;
            DateTime fromDate = new DateTime(today.Year, today.Month, 1);
            var totalRevenue = (from detail in _context.InvoiceDetails
                                join invoice in _context.Invoices
                                on detail.InvoiceID equals invoice.InvoiceID
                                where DbFunctions.TruncateTime(invoice.CreatedDate) >= fromDate
                                select (decimal?)detail.Quantity * detail.UnitPrice).Sum();
            return (int)(totalRevenue ?? 0); // Explicitly cast decimal to int
        }

        public int getTotalProductsSoldThisYear()
        {
            DateTime today = DateTime.Today;
            DateTime fromDate = new DateTime(today.Year, 1, 1);
            var totalSold = (from detail in _context.InvoiceDetails
                             join invoice in _context.Invoices
                             on detail.InvoiceID equals invoice.InvoiceID
                             where DbFunctions.TruncateTime(invoice.CreatedDate) >= fromDate
                             select (int?)detail.Quantity).Sum();
            return totalSold ?? 0;
        }

        public int getTotalRevenueThisYear()
        {
            DateTime today = DateTime.Today;
            DateTime fromDate = new DateTime(today.Year, 1, 1);
            var totalRevenue = (from detail in _context.InvoiceDetails
                                join invoice in _context.Invoices
                                on detail.InvoiceID equals invoice.InvoiceID
                                where DbFunctions.TruncateTime(invoice.CreatedDate) >= fromDate
                                select (decimal?)detail.Quantity * detail.UnitPrice).Sum();
            return (int)(totalRevenue ?? 0); // Explicitly cast decimal to int
        }

        public int getTotalProductsSoldThisWeek()
        {
            DateTime today = DateTime.Today;
            DateTime fromDate = today.AddDays(-7);

            var totalSold = (from detail in _context.InvoiceDetails
                             join invoice in _context.Invoices
                             on detail.InvoiceID equals invoice.InvoiceID
                             where DbFunctions.TruncateTime(invoice.CreatedDate) >= fromDate
                             select (int?)detail.Quantity).Sum();
            return totalSold ?? 0;
        }

        public int getTotalRevenueThisWeek()
        {
            DateTime today = DateTime.Today;
            DateTime fromDate = today.AddDays(-7);
            var totalRevenue = (from detail in _context.InvoiceDetails
                                join invoice in _context.Invoices
                                on detail.InvoiceID equals invoice.InvoiceID
                                where DbFunctions.TruncateTime(invoice.CreatedDate) >= fromDate
                                select (decimal?)detail.Quantity * detail.UnitPrice).Sum();
            return (int)(totalRevenue ?? 0); // Explicitly cast decimal to int
        }

        public List<ProductRevenueDTO> getTopSellingProduct()
        {
            var topSellingProducts = (from detail in _context.InvoiceDetails
                                      join invoice in _context.Invoices
                                      on detail.InvoiceID equals invoice.InvoiceID
                                      group detail by new { detail.ProductID, detail.Product.ProductName } into g
                                      orderby g.Sum(x => x.Quantity) descending
                                      select new ProductRevenueDTO
                                      {
                                          ProductName = g.Key.ProductName,
                                          TotalRevenue = g.Sum(x => x.Quantity * x.UnitPrice),
                                          TotalQuantitySold = g.Sum(x => x.Quantity)
                                      }).Take(5).ToList();
            return topSellingProducts;
        }

        public List<CategoryRevenueDTO> getTopSellingCategory()
        {
            var topSellingCategories = (from detail in _context.InvoiceDetails
                                        join invoice in _context.Invoices
                                        on detail.InvoiceID equals invoice.InvoiceID
                                        group detail by new { detail.Product.CategoryID, detail.Product.Category.CategoryName } into g
                                        orderby g.Sum(x => x.Quantity) descending
                                        select new CategoryRevenueDTO
                                        {
                                            CategoryName = g.Key.CategoryName,
                                            TotalRevenue = g.Sum(x => x.Quantity * x.UnitPrice)
                                        }).Take(5).ToList();
            return topSellingCategories;
        }

        public List<RevenueDTO> GetRevenueByMonthAndYear(int? selectedMonth, int? selectedYear)
        {
            DateTime today = DateTime.Today;
            int currentYear = today.Year;
            List<RevenueDTO> result = new List<RevenueDTO>();

            // Case 1: Chỉ chọn tháng (không chọn năm)
            if (selectedMonth.HasValue && !selectedYear.HasValue)
            {
                DateTime startDate = new DateTime(currentYear, selectedMonth.Value, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                var dailyRevenue = _context.InvoiceDetails
                    .Join(_context.Invoices,
                        detail => detail.InvoiceID,
                        invoice => invoice.InvoiceID,
                        (detail, invoice) => new { detail, invoice })
                    .Where(x => DbFunctions.TruncateTime(x.invoice.CreatedDate) >= startDate
                             && DbFunctions.TruncateTime(x.invoice.CreatedDate) <= endDate)
                    .GroupBy(x => DbFunctions.TruncateTime(x.invoice.CreatedDate))
                    .Select(g => new RevenueDTO
                    {
                        Date = g.Key.Value,
                        TotalRevenue = g.Sum(x => x.detail.Quantity * x.detail.UnitPrice)
                    })
                    .OrderBy(x => x.Date)
                    .ToList();

                // Fill in all days of the month
                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    var revenue = dailyRevenue.FirstOrDefault(x => x.Date.Date == date.Date)
                        ?? new RevenueDTO { Date = date, TotalRevenue = 0 };
                    result.Add(revenue);
                }
            }
            // Case 2: Chọn cả năm và tháng
            else if (selectedMonth.HasValue && selectedYear.HasValue)
            {
                DateTime startDate = new DateTime(selectedYear.Value, selectedMonth.Value, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                var dailyRevenue = _context.InvoiceDetails
                    .Join(_context.Invoices,
                        detail => detail.InvoiceID,
                        invoice => invoice.InvoiceID,
                        (detail, invoice) => new { detail, invoice })
                    .Where(x => DbFunctions.TruncateTime(x.invoice.CreatedDate) >= startDate
                             && DbFunctions.TruncateTime(x.invoice.CreatedDate) <= endDate)
                    .GroupBy(x => DbFunctions.TruncateTime(x.invoice.CreatedDate))
                    .Select(g => new RevenueDTO
                    {
                        Date = g.Key.Value,
                        TotalRevenue = g.Sum(x => x.detail.Quantity * x.detail.UnitPrice)
                    })
                    .OrderBy(x => x.Date)
                    .ToList();

                // Fill in all days of the month
                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                {
                    var revenue = dailyRevenue.FirstOrDefault(x => x.Date.Date == date.Date)
                        ?? new RevenueDTO { Date = date, TotalRevenue = 0 };
                    result.Add(revenue);
                }
            }
            // Case 3: Chỉ chọn năm (không chọn tháng)
            else if (!selectedMonth.HasValue && selectedYear.HasValue)
            {
                DateTime startDate = new DateTime(selectedYear.Value, 1, 1);
                DateTime endDate = new DateTime(selectedYear.Value, 12, 31);

                var monthlyRevenue = _context.InvoiceDetails
                        .Join(_context.Invoices,
                            detail => detail.InvoiceID,
                            invoice => invoice.InvoiceID,
                            (detail, invoice) => new { detail, invoice })
                        .Where(x => x.invoice.CreatedDate.Year == selectedYear.Value)
                        .GroupBy(x => new { Year = x.invoice.CreatedDate.Year, Month = x.invoice.CreatedDate.Month })
                        .AsEnumerable() // Dùng LINQ to Objects từ đây
                        .Select(g => new RevenueDTO
                        {
                            Date = new DateTime(g.Key.Year, g.Key.Month, 1), // Được phép dùng khởi tạo DateTime ở đây
                            TotalRevenue = g.Sum(x => x.detail.Quantity * x.detail.UnitPrice)
                        })
                        .OrderBy(x => x.Date)
                        .ToList();

                // Fill in all months of the year
                for (int month = 1; month <= 12; month++)
                {
                    DateTime date = new DateTime(selectedYear.Value, month, 1);
                    var revenue = monthlyRevenue.FirstOrDefault(x => x.Date.Month == month)
                        ?? new RevenueDTO { Date = date, TotalRevenue = 0 };
                    result.Add(revenue);
                }
            }
            // Case 4: Neither month nor year selected (return empty list or handle as needed)
            else
            {
                // Return empty list or throw exception based on requirements
                return result;
            }
            return result;
        }
    }
}
