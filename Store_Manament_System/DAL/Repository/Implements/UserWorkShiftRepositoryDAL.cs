using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserWorkShiftRepositoryDAL : IUserWorkShiftRepositoryDAL
    {

        private readonly StoreContext _context = new StoreContext();

        public List<UserWorkShift> GetAllUserWorkShifts()
        {
            return _context.UserWorkShifts.ToList();
        }

        public bool AddUserWorkShift(UserWorkShift userWorkShift)
        {
            try
            {
                _context.UserWorkShifts.Add(userWorkShift);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool HasWorkShiftOnDate(int userId, DateTime workDate)
        {
            DateTime date = workDate.Date;
            DateTime nextDate = date.AddDays(1);

            return _context.UserWorkShifts.Any(uws =>
                uws.UserID == userId &&
                uws.WorkDate >= date &&
                uws.WorkDate < nextDate
            );
        }

        public List<UserWorkShift> GetUserWorkShiftsByMonthAndYear(int month, int year)
        {
            return _context.UserWorkShifts
                .Where(uws => uws.WorkDate.Month == month && uws.WorkDate.Year == year)
                .ToList();
        }

        public List<EmployeeSalaryDTO> GetSalaryEachWorkShiftThisMonth(int userId)
        {
            DateTime now = DateTime.Now;
            int targetMonth = now.AddMonths(-1).Month;
            int targetYear = now.AddMonths(-1).Year;

            return (from workShift in _context.WorkShifts
                    join userWorkShift in _context.UserWorkShifts
                        on workShift.WorkShiftID equals userWorkShift.WorkShiftID
                    where userWorkShift.UserID == userId &&
                          userWorkShift.WorkDate.Month == targetMonth &&
                          userWorkShift.WorkDate.Year == targetYear
                    select new EmployeeSalaryDTO
                    {
                        EmployeeId = (int)userWorkShift.UserID,
                        Email = userWorkShift.User.Email,
                        EmployeeName = userWorkShift.User.FullName,
                        WorkDate = userWorkShift.WorkDate,
                        Salary = workShift.WorkShiftSalary
                    }).ToList();
        }

    }
}