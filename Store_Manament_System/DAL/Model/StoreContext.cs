using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Model
{
    public partial class StoreContext : DbContext
    {
        public StoreContext()
            : base("name=StoreContext")
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryPromotion> CategoryPromotions { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductDemandHistory> ProductDemandHistories { get; set; }
        public virtual DbSet<ProductPromotion> ProductPromotions { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<RevenueReport> RevenueReports { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .Property(e => e.HoursWorked)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.DiscountRate)
                .HasPrecision(5, 2);
        }
    }
}
