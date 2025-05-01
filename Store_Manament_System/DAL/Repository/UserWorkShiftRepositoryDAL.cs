using DAL.Model;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserWorkShiftRepositoryDAL
    {

        private readonly StoreContext employee = new StoreContext();

        public List<UserWorkShiftDTO> GetAllUserWorkShift()
        {
            var query = from uws in employee.UserWorkShifts
                        join u in employee.Users on uws.UserID equals u.UserID into userGroup
                        from u in userGroup.DefaultIfEmpty() // Left join để không bỏ sót nếu không tìm thấy user
                        join ws in employee.WorkShifts on uws.WorkShiftID equals ws.WorkShiftID into workShiftGroup
                        from ws in workShiftGroup.DefaultIfEmpty() // Left join để không bỏ sót nếu không tìm thấy work shift
                        select new UserWorkShiftDTO
                        {
                            userID = uws.UserID ?? 0,
                            fullName = u != null ? u.FullName : "N/A", 
                            gender = u != null ? u.Gender : "N/A",     
                            workShiftName = ws != null ? ws.WorkShiftName : "N/A", 
                            workDate = uws.WorkDate
                        };

            return query.ToList();
        }

        // Phương thức thêm ca làm việc thủ công  cho nhân viên
        public bool AddUserWorkShift(UserWorkShiftDTO userWorkShiftDto)
        {
            try
            {
                var userWorkShift = new UserWorkShift
                {
                    UserID = userWorkShiftDto.userID,
                    WorkShiftID = userWorkShiftDto.workShiftID,
                    WorkDate = userWorkShiftDto.workDate // Đảm bảo WorkDate được gán
                };
                employee.UserWorkShifts.Add(userWorkShift);
                employee.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when adding work: {ex.Message}", ex);
            }
        }

        //kiểm tra xem nhân viên có ca làm việc trong ngày hay không
        public bool HasWorkShiftOnDate(int userId, DateTime workDate)
        {
            var dateOnly = workDate.Date;
            var nextDate = dateOnly.AddDays(1);

            return employee.UserWorkShifts.Any(uws =>
                uws.UserID == userId &&
                uws.WorkDate >= dateOnly &&
                uws.WorkDate < nextDate
            );
        }


    }
}
