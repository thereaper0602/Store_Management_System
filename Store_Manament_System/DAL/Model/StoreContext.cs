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

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Promotions> Promotions { get; set; }
        public virtual DbSet<RevenueReports> RevenueReports { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserWorkShift> UserWorkShift { get; set; }
        public virtual DbSet<WorkShifts> WorkShifts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Promotions>()
                .Property(e => e.DiscountRate)
                .HasPrecision(5, 2);
        }
    }
}
