namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Holiday
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Holiday()
        {
            ProductDemandHistories = new HashSet<ProductDemandHistory>();
        }

        public int HolidayID { get; set; }

        [Required]
        [StringLength(255)]
        public string HolidayName { get; set; }

        [Column(TypeName = "date")]
        public DateTime HolidayDate { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDemandHistory> ProductDemandHistories { get; set; }
    }
}
