namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvoiceDetails
    {
        [Key]
        public int DetailID { get; set; }

        public int? InvoiceID { get; set; }

        public int? ProductID { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal LineTotal { get; set; }

        public int? PromotionID { get; set; }

        public virtual Invoices Invoices { get; set; }

        public virtual Products Products { get; set; }

        public virtual Promotions Promotions { get; set; }
    }
}
