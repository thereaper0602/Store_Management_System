namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RevenueReport
    {
        [Key]
        public int ReportID { get; set; }

        [Required]
        [StringLength(50)]
        public string ReportType { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReportDate { get; set; }

        public decimal TotalRevenue { get; set; }
    }
}
