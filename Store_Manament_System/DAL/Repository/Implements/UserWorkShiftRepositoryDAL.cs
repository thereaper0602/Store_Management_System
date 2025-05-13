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


    }
}