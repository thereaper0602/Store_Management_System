using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IUserWorkShiftRepositoryDAL
    {
        bool AddUserWorkShift(UserWorkShift userWorkShift);
        List<UserWorkShift> GetAllUserWorkShifts();
        List<UserWorkShift> GetUserWorkShiftsByMonthAndYear(int month, int year);
        bool HasWorkShiftOnDate(int userId, DateTime workDate);
        List<EmployeeSalaryDTO> GetSalaryEachWorkShiftThisMonth(int userId);
    }
}