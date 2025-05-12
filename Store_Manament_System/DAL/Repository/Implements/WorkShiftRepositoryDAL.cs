using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class WorkShiftRepositoryDAL : IWorkShiftRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();
        public List<WorkShiftDTO> GetWorkShift()
        {
            return _context.WorkShifts
                .Select(w => new WorkShiftDTO()
                {
                    workShiftID = w.WorkShiftID,
                    workShiftName = w.WorkShiftName,
                    //workShiftPrice = w.WorkShiftSalary
                })
                .ToList();
        }


    }
}
