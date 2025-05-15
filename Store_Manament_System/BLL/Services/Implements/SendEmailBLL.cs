using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using DTO.DTO;
using DAL.Repository;
using System.Globalization;

namespace BLL.Services.Implements
{
    public class SendEmailBLL : ISendEmailBLL
    {
        private readonly IUserWorkShiftRepositoryDAL _userWorkShiftRepositoryDAL = new UserWorkShiftRepositoryDAL();
        private readonly IUserRepositoryDAL _userRepositoryDAL = new UserRepositoryDAL();
        public string GenerateSalaryEmailHtml(List<EmployeeSalaryDTO> salaries)
        {
            if (salaries == null || !salaries.Any()) return "<p>No salary data available for this month.</p>";

            var employee = salaries.First();
            var html = new StringBuilder();

            html.Append($@"
            <h2>Salary Details for {DateTime.Now:MMMM yyyy}</h2>
            <p><strong>Employee Name:</strong> {employee.EmployeeName}</p>
            <p><strong>Email:</strong> {employee.Email}</p>
            <table border='1' cellpadding='8' cellspacing='0' style='border-collapse: collapse; width: 100%;'>
                <thead style='background-color: #f2f2f2;'>
                    <tr>
                        <th>Work Date</th>
                        <th>Shift Salary</th>
                    </tr>
                </thead>
                <tbody>");

                foreach (var salary in salaries)
                {
                    html.Append($@"
                <tr>
                    <td>{salary.WorkDate:dd/MM/yyyy}</td>
                    <td>{salary.Salary.ToString("C", CultureInfo.GetCultureInfo("vi-VN"))}</td>
                </tr>");
                }

                var totalSalary = salaries.Sum(s => s.Salary);
                html.Append($@"
                </tbody>
                <tfoot>
                    <tr>
                        <td><strong>Total Salary</strong></td>
                        <td><strong>{totalSalary.ToString("C",CultureInfo.GetCultureInfo("vi-VN"))}</strong></td>
                    </tr>
                </tfoot>
            </table>");

            return html.ToString();
        }

        public bool SendEmail(int userID)
        {
            // Get the user information
            var user = _userRepositoryDAL.GetUserById(userID);
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            // Get the salary information for the user
            List<EmployeeSalaryDTO> employeeSalaries = _userWorkShiftRepositoryDAL.GetSalaryEachWorkShiftThisMonth(userID);
            string html = this.GenerateSalaryEmailHtml(employeeSalaries);

            string fromEmail = "dangcapcothua2903@gmail.com";
            string appPassword = "";
            string toEmail = user.Email;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(fromEmail, "Hệ thống quản lý nhân sự");
            mailMessage.To.Add(toEmail);
            mailMessage.Subject = $"Bảng lương tháng {DateTime.Now:MM/yyyy}";
            mailMessage.Body = html + @"
            <p style='font-size:12px; color:gray;'>Email được gửi tự động từ hệ thống. Mọi thắc mắc vui lòng liên hệ: hr@yourcompany.vn</p>";
            mailMessage.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromEmail, appPassword);

            try
            {
                smtp.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
