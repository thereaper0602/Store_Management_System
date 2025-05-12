using DTO.DTO;
using System;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IUserWorkShiftRepositoryDAL
    {
        bool AddUserWorkShift(UserWorkShiftDTO userWorkShiftDto);
        List<UserWorkShiftDTO> GetAllUserWorkShift();
        bool HasWorkShiftOnDate(int userId, DateTime workDate);
    }
}