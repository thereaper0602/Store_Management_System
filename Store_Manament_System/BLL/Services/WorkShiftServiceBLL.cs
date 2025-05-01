using DAL.Repository;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class WorkShiftServiceBLL
    {
        private readonly WorkShiftRepositoryDAL work = new WorkShiftRepositoryDAL();
        public List<WorkShiftDTO> GetAllWorkShift()
        {

            return work.GetWorkShift();
        }
    }
}
