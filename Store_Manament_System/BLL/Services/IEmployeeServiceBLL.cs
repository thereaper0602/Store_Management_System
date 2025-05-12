using DTO.DTO;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IEmployeeServiceBLL
    {
        bool AddUser(ImageDTO imageDTO, UserDTO employeeDTO);
        bool AddUserWorkShift(UserWorkShiftDTO userWorkShiftDto);
        bool DeleteUser(int userId, ImageDTO imageDTO);
        bool DeleteUsers(List<int> userIds);
        List<UserDTO> GetAllUser();
        List<UserWorkShiftDTO> GetAllUserWorkShift();
        string GetFullNameByUserId(int userId);
        List<SalaryDTO> GetSalariesByMonthAndYear(int month, int year);
        bool HasWorkShiftOnDate(int userId, DateTime workDate);
        bool IsValidUserWithRole(int userId);
        List<UserDTO> SearchUser(string searchTerm);
        bool UpdateUser(UserDTO employeeDTO);
    }
}