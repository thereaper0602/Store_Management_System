namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserWorkShift")]
    public partial class UserWorkShift
    {
        public int UserWorkShiftID { get; set; }

        public int? UserID { get; set; }

        public int? WorkShiftID { get; set; }

        public virtual User User { get; set; }

        public virtual WorkShift WorkShift { get; set; }
    }
}
