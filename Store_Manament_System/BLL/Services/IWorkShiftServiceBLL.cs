using DTO.DTO;
using System.Collections.Generic;

namespace BLL.Services
{
    public interface IWorkShiftServiceBLL
    {
        List<WorkShiftDTO> GetAllWorkShift();
    }
}