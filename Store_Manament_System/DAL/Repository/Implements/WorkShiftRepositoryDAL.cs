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
        public List<WorkShift> GetAllWorkShifts()
        {
            return _context.WorkShifts.ToList();
        }

    }
}