namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductDemandHistory")]
    public partial class ProductDemandHistory
    {
        [Key]
        public int DemandID { get; set; }

        public int? ProductID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DemandDate { get; set; }

        public int QuantitySold { get; set; }

        public int? PromotionID { get; set; }

        public int? HolidayID { get; set; }

        public virtual Holiday Holiday { get; set; }

        public virtual Product Product { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
