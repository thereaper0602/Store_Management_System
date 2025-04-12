namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendance")]
    public partial class Attendance
    {
        public int AttendanceID { get; set; }

        public int? UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime WorkDate { get; set; }

        public TimeSpan ClockIn { get; set; }

        public TimeSpan ClockOut { get; set; }

        public decimal HoursWorked { get; set; }

        public virtual User User { get; set; }
    }
}
