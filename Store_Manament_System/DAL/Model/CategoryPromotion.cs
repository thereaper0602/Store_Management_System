namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CategoryPromotion
    {
        public int CategoryPromotionID { get; set; }

        public int? CategoryID { get; set; }

        public int? PromotionID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Promotion Promotion { get; set; }
    }
}
