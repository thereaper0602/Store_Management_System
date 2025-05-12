using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DAL.Repository;
using DTO.DTO;

namespace BLL
{
    public class ReportServicesBLL : IReportServicesBLL
    {
        private readonly ReportRepositoryDAL reportRepositoryDAL = new ReportRepositoryDAL();

        public int getTotalCostOfGoodsSoldToday()
        {
            try
            {
                return reportRepositoryDAL.getTotalCostOfGoodsSoldToday();
            }
            catch (SqlException e)
            {
                throw new Exception("Database error : ", e);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int getTotalCostOfGoodsSoldThisWeek()
        {
            try
            {
                return reportRepositoryDAL.getTotalCostOfGoodsSoldThisWeek();
            }
            catch (SqlException e)
            {
                throw new Exception("Database error : ", e);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int getTotalCostOfGoodsSoldThisMonth()
        {
            try
            {
                return reportRepositoryDAL.getTotalCostOfGoodsSoldThisMonth();
            }
            catch (SqlException e)
            {
                throw new Exception("Database error : ", e);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int getTotalCostOfGoodsSoldThisYear()
        {
            try
            {
                return reportRepositoryDAL.getTotalCostOfGoodsSoldThisYear();
            }
            catch (SqlException e)
            {
                throw new Exception("Database error : ", e);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int getTotalProductsSoldToday()
        {
            try
            {
                return reportRepositoryDAL.getTotalProductsSoldToday();
            }
            catch (SqlException e)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu", e);
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi không xác định", e);
            }
        }

        public int getTotalRevenueToday()
        {
            try
            {
                return reportRepositoryDAL.getTotalRevenueToday();
            }
            catch (SqlException e)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu", e);
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi không xác định", e);
            }
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
