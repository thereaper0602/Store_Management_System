using DTO.DTO;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IReportRepositoryDAL
    {
        List<RevenueDTO> GetRevenueByMonthAndYear(int? selectedMonth, int? selectedYear);
        List<CategoryRevenueDTO> getTopSellingCategory();
        List<ProductRevenueDTO> getTopSellingProduct();
        int getTotalCostOfGoodsSoldThisMonth();
        int getTotalCostOfGoodsSoldThisWeek();
        int getTotalCostOfGoodsSoldThisYear();
        int getTotalCostOfGoodsSoldToday();
        int getTotalProductsSoldThisMonth();
        int getTotalProductsSoldThisWeek();
        int getTotalProductsSoldThisYear();
        int getTotalProductsSoldToday();
        int getTotalRevenueThisMonth();
        int getTotalRevenueThisWeek();
        int getTotalRevenueThisYear();
        int getTotalRevenueToday();
    }
}