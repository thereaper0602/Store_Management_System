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

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceStatu> InvoiceStatus { get; set; }
        public virtual DbSet<ProductPromotion> ProductPromotions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<RevenueReport> RevenueReports { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserWorkShift> UserWorkShifts { get; set; }
        public virtual DbSet<WorkShift> WorkShifts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Category)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDetails)
                .WithOptional(e => e.Invoice)
                .WillCascadeOnDelete();

            modelBuilder.Entity<InvoiceStatu>()
                .HasMany(e => e.Invoices)
                .WithOptional(e => e.InvoiceStatu)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductPromotions)
                .WithOptional(e => e.Product)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Stocks)
                .WithOptional(e => e.Product)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Promotion>()
                .Property(e => e.DiscountRate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Promotion>()
                .HasMany(e => e.ProductPromotions)
                .WithOptional(e => e.Promotion)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserWorkShifts)
                .WithOptional(e => e.User)
                .WillCascadeOnDelete();

            modelBuilder.Entity<WorkShift>()
                .HasMany(e => e.UserWorkShifts)
                .WithOptional(e => e.WorkShift)
                .WillCascadeOnDelete();
        }
    }
}
