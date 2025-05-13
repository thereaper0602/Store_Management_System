using DTO.DTO;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IEmployeeServiceBLL
    {
        bool AddUser(UserDTO userDTO, ImageDTO imageDTO);
        bool AddUserWorkShift(UserWorkShiftDTO dto);
        bool DeleteUser(int userId);
        bool DeleteUsers(List<int> userIds);
        List<UserDTO> GetAllUser();
        List<UserWorkShiftDTO> GetAllUserWorkShift();
        string GetFullNameByUserId(int userId);
        List<SalaryDTO> GetSalariesByMonthAndYear(int month, int year);
        UserDTO GetUserById(int userId);
        bool HasWorkShiftOnDate(int userId, DateTime workDate);
        bool IsValidUserWithRole(int userId);
        List<UserDTO> SearchUsers(string keyword);
        bool UpdateUser(UserDTO userDTO);
    }
}