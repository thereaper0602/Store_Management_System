namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFirstAndLastNameToUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendance",
                c => new
                    {
                        AttendanceID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        WorkDate = c.DateTime(nullable: false, storeType: "date"),
                        ClockIn = c.Time(nullable: false, precision: 7),
                        ClockOut = c.Time(nullable: false, precision: 7),
                        HoursWorked = c.Decimal(nullable: false, precision: 5, scale: 2),
                    })
                .PrimaryKey(t => t.AttendanceID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 255),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 255),
                        RoleID = c.Int(),
                        PhoneNumber = c.String(maxLength: 15),
                        Email = c.String(maxLength: 255),
                        BaseSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HireDate = c.DateTime(nullable: false, storeType: "date"),
                        ImageID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Images", t => t.ImageID)
                .ForeignKey("dbo.UserRoles", t => t.RoleID)
                .Index(t => t.RoleID)
                .Index(t => t.ImageID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImageName = c.String(nullable: false, maxLength: 255),
                        ImagePath = c.String(nullable: false),
                        UploadDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ImageID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 255),
                        ImageID = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryID)
                .ForeignKey("dbo.Images", t => t.ImageID)
                .Index(t => t.ImageID);
            
            CreateTable(
                "dbo.CategoryPromotions",
                c => new
                    {
                        CategoryPromotionID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(),
                        PromotionID = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryPromotionID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .ForeignKey("dbo.Promotions", t => t.PromotionID)
                .Index(t => t.CategoryID)
                .Index(t => t.PromotionID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.Int(nullable: false, identity: true),
                        PromotionName = c.String(nullable: false, maxLength: 255),
                        DiscountRate = c.Decimal(nullable: false, precision: 5, scale: 2),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(nullable: false, storeType: "date"),
                        PromotionType = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PromotionID);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        DetailID = c.Int(nullable: false, identity: true),
                        InvoiceID = c.Int(),
                        ProductID = c.Int(),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionID = c.Int(),
                    })
                .PrimaryKey(t => t.DetailID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID)
                .ForeignKey("dbo.Promotions", t => t.PromotionID)
                .Index(t => t.InvoiceID)
                .Index(t => t.ProductID)
                .Index(t => t.PromotionID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        CustomerID = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.InvoiceID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 255),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                        LoyaltyPoints = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        CartID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CartID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        CartItemID = c.Int(nullable: false, identity: true),
                        CartID = c.Int(),
                        ProductID = c.Int(),
                        Quantity = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CartItemID)
                .ForeignKey("dbo.Carts", t => t.CartID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.CartID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 255),
                        CategoryID = c.Int(),
                        StockQuantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpiryDate = c.DateTime(storeType: "date"),
                        Barcode = c.String(maxLength: 50),
                        Description = c.String(),
                        ImageID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .ForeignKey("dbo.Images", t => t.ImageID)
                .Index(t => t.CategoryID)
                .Index(t => t.ImageID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(),
                        ProductID = c.Int(),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        OrderDate = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.ProductDemandHistory",
                c => new
                    {
                        DemandID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(),
                        DemandDate = c.DateTime(nullable: false, storeType: "date"),
                        QuantitySold = c.Int(nullable: false),
                        PromotionID = c.Int(),
                        HolidayID = c.Int(),
                    })
                .PrimaryKey(t => t.DemandID)
                .ForeignKey("dbo.Holidays", t => t.HolidayID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .ForeignKey("dbo.Promotions", t => t.PromotionID)
                .Index(t => t.ProductID)
                .Index(t => t.PromotionID)
                .Index(t => t.HolidayID);
            
            CreateTable(
                "dbo.Holidays",
                c => new
                    {
                        HolidayID = c.Int(nullable: false, identity: true),
                        HolidayName = c.String(nullable: false, maxLength: 255),
                        HolidayDate = c.DateTime(nullable: false, storeType: "date"),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.HolidayID);
            
            CreateTable(
                "dbo.ProductPromotions",
                c => new
                    {
                        ProductPromotionID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(),
                        PromotionID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductPromotionID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .ForeignKey("dbo.Promotions", t => t.PromotionID)
                .Index(t => t.ProductID)
                .Index(t => t.PromotionID);
            
            CreateTable(
                "dbo.ProductReviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(),
                        CustomerID = c.Int(),
                        Rating = c.Int(nullable: false),
                        Comment = c.String(),
                        ReviewDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.ProductID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.RevenueReports",
                c => new
                    {
                        ReportID = c.Int(nullable: false, identity: true),
                        ReportType = c.String(nullable: false, maxLength: 50),
                        ReportDate = c.DateTime(nullable: false, storeType: "date"),
                        TotalRevenue = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ReportID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleID", "dbo.UserRoles");
            DropForeignKey("dbo.Users", "ImageID", "dbo.Images");
            DropForeignKey("dbo.Categories", "ImageID", "dbo.Images");
            DropForeignKey("dbo.InvoiceDetails", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.Invoices", "UserID", "dbo.Users");
            DropForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Carts", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.ProductReviews", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductReviews", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.ProductPromotions", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.ProductPromotions", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductDemandHistory", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.ProductDemandHistory", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductDemandHistory", "HolidayID", "dbo.Holidays");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.InvoiceDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "ImageID", "dbo.Images");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.CartItems", "ProductID", "dbo.Products");
            DropForeignKey("dbo.CartItems", "CartID", "dbo.Carts");
            DropForeignKey("dbo.CategoryPromotions", "PromotionID", "dbo.Promotions");
            DropForeignKey("dbo.CategoryPromotions", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Attendance", "UserID", "dbo.Users");
            DropIndex("dbo.ProductReviews", new[] { "CustomerID" });
            DropIndex("dbo.ProductReviews", new[] { "ProductID" });
            DropIndex("dbo.ProductPromotions", new[] { "PromotionID" });
            DropIndex("dbo.ProductPromotions", new[] { "ProductID" });
            DropIndex("dbo.ProductDemandHistory", new[] { "HolidayID" });
            DropIndex("dbo.ProductDemandHistory", new[] { "PromotionID" });
            DropIndex("dbo.ProductDemandHistory", new[] { "ProductID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Products", new[] { "ImageID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.CartItems", new[] { "ProductID" });
            DropIndex("dbo.CartItems", new[] { "CartID" });
            DropIndex("dbo.Carts", new[] { "CustomerID" });
            DropIndex("dbo.Invoices", new[] { "CustomerID" });
            DropIndex("dbo.Invoices", new[] { "UserID" });
            DropIndex("dbo.InvoiceDetails", new[] { "PromotionID" });
            DropIndex("dbo.InvoiceDetails", new[] { "ProductID" });
            DropIndex("dbo.InvoiceDetails", new[] { "InvoiceID" });
            DropIndex("dbo.CategoryPromotions", new[] { "PromotionID" });
            DropIndex("dbo.CategoryPromotions", new[] { "CategoryID" });
            DropIndex("dbo.Categories", new[] { "ImageID" });
            DropIndex("dbo.Users", new[] { "ImageID" });
            DropIndex("dbo.Users", new[] { "RoleID" });
            DropIndex("dbo.Attendance", new[] { "UserID" });
            DropTable("dbo.RevenueReports");
            DropTable("dbo.UserRoles");
            DropTable("dbo.ProductReviews");
            DropTable("dbo.ProductPromotions");
            DropTable("dbo.Holidays");
            DropTable("dbo.ProductDemandHistory");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.CartItems");
            DropTable("dbo.Carts");
            DropTable("dbo.Customers");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Promotions");
            DropTable("dbo.CategoryPromotions");
            DropTable("dbo.Categories");
            DropTable("dbo.Images");
            DropTable("dbo.Users");
            DropTable("dbo.Attendance");
        }
    }
}
