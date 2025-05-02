namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

<<<<<<<< HEAD:Store_Manament_System/DAL/Model/WorkShift.cs
    public partial class WorkShift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkShift()
        {
            UserWorkShifts = new HashSet<UserWorkShift>();
        }

========
    public partial class WorkShifts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkShifts()
        {
            UserWorkShift = new HashSet<UserWorkShift>();
        }

        [Key]
>>>>>>>> origin/giang_category_service:Store_Manament_System/DAL/Model/WorkShifts.cs
        public int WorkShiftID { get; set; }

        [Required]
        [StringLength(100)]
        public string WorkShiftName { get; set; }

        public decimal WorkShiftSalary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
<<<<<<<< HEAD:Store_Manament_System/DAL/Model/WorkShift.cs
        public virtual ICollection<UserWorkShift> UserWorkShifts { get; set; }
========
        public virtual ICollection<UserWorkShift> UserWorkShift { get; set; }
>>>>>>>> origin/giang_category_service:Store_Manament_System/DAL/Model/WorkShifts.cs
    }
}
