namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        public int StockID { get; set; }

        public int? ProductID { get; set; }

        public decimal Cost { get; set; }

        public int StockQuantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ImportDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
