namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkShift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkShift()
        {
            UserWorkShifts = new HashSet<UserWorkShift>();
        }

        public int WorkShiftID { get; set; }

        [Required]
        [StringLength(100)]
        public string WorkShiftName { get; set; }

        public decimal WorkShiftSalary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserWorkShift> UserWorkShifts { get; set; }
    }
}
