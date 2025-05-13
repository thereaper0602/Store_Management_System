using DAL.Repository;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class WorkShiftServiceBLL : IWorkShiftServiceBLL
    {
        private readonly WorkShiftRepositoryDAL work = new WorkShiftRepositoryDAL();
        public List<WorkShiftDTO> GetAllWorkShift()
        {
            return work.GetAllWorkShifts()
                .Select(w => new WorkShiftDTO
                {
                    workShiftID = w.WorkShiftID,
                    workShiftName = w.WorkShiftName,

                    // workShiftPrice = w.WorkShiftSalary
                }).ToList();
        }

    }
}