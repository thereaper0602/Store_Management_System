using DAL.Model;
using System.Collections.Generic;

namespace DAL.Repository
{
    public interface IWorkShiftRepositoryDAL
    {
        List<WorkShift> GetAllWorkShifts();
    }
}