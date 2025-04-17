using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DAL.Repository;
using DTO.DTO;

namespace BLL
{
    public class ReportServicesBLL
    {
        private readonly ReportRepositoryDAL reportRepositoryDAL = new ReportRepositoryDAL();

        public int getTotalProducts()
        {
            return reportRepositoryDAL.getTotalProducts();
        }

        public int getTotalProductsSoldToday()
        {
            return reportRepositoryDAL.getTotalProductsSoldToday();
        }

        public int getTotalRevenueToday()
        {
            return reportRepositoryDAL.getTotalRevenueToday();
        }

        public int getTotalProductsSoldThisMonth()
        {
            return reportRepositoryDAL.getTotalProductsSoldThisMonth();
        }

        public int getTotalRevenueThisMonth()
        {
            return reportRepositoryDAL.getTotalRevenueThisMonth();
        }

        public int getTotalProductsSoldThisYear()
        {
            return reportRepositoryDAL.getTotalProductsSoldThisYear();
        }

        public int getTotalRevenueThisYear()
        {
            return reportRepositoryDAL.getTotalRevenueThisYear();
        }

        public int getTotalProductsSoldThisWeek()
        {
            return reportRepositoryDAL.getTotalProductsSoldThisWeek();
        }

        public int getTotalRevenueThisWeek()
        {
            return reportRepositoryDAL.getTotalRevenueThisWeek();
        }

        public List<ProductRevenueDTO> getTopSellingProduct()
        {
            return reportRepositoryDAL.getTopSellingProduct();
        }

        public List<CategoryRevenueDTO> getTopSellingCategory()
        {
            return reportRepositoryDAL.getTopSellingCategory();
        }

        public List<RevenueDTO> GetRevenueByMonthAndYear(int? selectedMonth, int? selectedYear)
        {
            return reportRepositoryDAL.GetRevenueByMonthAndYear(selectedMonth, selectedYear);
        }
    }
}
