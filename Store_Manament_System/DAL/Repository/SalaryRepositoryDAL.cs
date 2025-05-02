using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Model;
using DTO.DTO;

namespace DAL.Repository
{
    public class SalaryRepositoryDAL
    {
        private readonly StoreContext _context = new StoreContext();

        public List<SalaryDTO> GetSalariesByMonthAndYear(int month, int year)
        {
            // Lấy danh sách nhân viên có RoleID = 2
            var users = _context.Users
                .Where(u => u.RoleID == 2)
                .Select(u => new { u.UserID, u.FullName, u.Gender })
                .ToList();

            // Lấy danh sách ca làm việc trong tháng và năm được chọn
            var userWorkShifts = _context.UserWorkShifts
                .Where(uws => uws.WorkDate.Month == month && uws.WorkDate.Year == year)
                .ToList();

            // Lấy thông tin ca làm việc và lương mỗi giờ
            var workShifts = _context.WorkShifts
                .Select(ws => new { ws.WorkShiftID, ws.WorkShiftSalary })
                .ToList();

            // Tính toán lương cho từng nhân viên
            var salaries = users.Select(user =>
            {
                // Lấy ca làm việc của nhân viên này
                var userShifts = userWorkShifts.Where(uws => uws.UserID == user.UserID).ToList();

                // Tính số lần làm ca Morning (WorkShiftID = 1)
                int morningShifts = userShifts.Count(uws => uws.WorkShiftID == 1);
                // Tính số lần làm ca Afternoon (WorkShiftID = 2)
                int afternoonShifts = userShifts.Count(uws => uws.WorkShiftID == 2);
                // Tính số lần làm ca Evening (WorkShiftID = 3)
                int eveningShifts = userShifts.Count(uws => uws.WorkShiftID == 3);

                // Lấy lương mỗi giờ của từng ca
                decimal morningSalaryPerHour = workShifts.FirstOrDefault(ws => ws.WorkShiftID == 1)?.WorkShiftSalary ?? 0;
                decimal afternoonSalaryPerHour = workShifts.FirstOrDefault(ws => ws.WorkShiftID == 2)?.WorkShiftSalary ?? 0;
                decimal eveningSalaryPerHour = workShifts.FirstOrDefault(ws => ws.WorkShiftID == 3)?.WorkShiftSalary ?? 0;

                // Tính tổng lương: (Số lần * Lương 1 giờ * 8 giờ)
                decimal totalSalary = (morningShifts * morningSalaryPerHour * 8) +
                                     (afternoonShifts * afternoonSalaryPerHour * 8) +
                                     (eveningShifts * eveningSalaryPerHour * 8);

                return new SalaryDTO
                {
                    userID = user.UserID,
                    fullName = user.FullName,
                    gender = user.Gender,
                    morningShifts = morningShifts,
                    afternoonShifts = afternoonShifts,
                    eveningShifts = eveningShifts,
                    salary = totalSalary,
                    //Status = "Active" // Gán giá trị mặc định cho Status
                };
            }).ToList();

            return salaries;
        }
    }
}