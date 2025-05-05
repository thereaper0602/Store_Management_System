namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductPromotion")]
    public partial class ProductPromotion
    {
        public int ProductPromotionID { get; set; }

        public int? ProductID { get; set; }

        public int? PromotionID { get; set; }
    }
}
