using DTO.DTO;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IWorkShiftRepositoryDAL
    {
        List<WorkShiftDTO> GetWorkShift();
    }
}