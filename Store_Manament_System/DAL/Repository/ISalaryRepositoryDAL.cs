using DTO.DTO;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface ISalaryRepositoryDAL
    {
        List<SalaryDTO> GetSalariesByMonthAndYear(int month, int year);
    }
}