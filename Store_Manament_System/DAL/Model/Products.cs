namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            InvoiceDetails = new HashSet<InvoiceDetails>();
        }

        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        public int? CategoryID { get; set; }

        public int StockQuantity { get; set; }

        public decimal Price { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }

        [StringLength(50)]
        public string Barcode { get; set; }

        public string Description { get; set; }

        public int? ImageID { get; set; }

        public int? PromotionID { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual Images Images { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }

        public virtual Promotions Promotions { get; set; }
    }
}
