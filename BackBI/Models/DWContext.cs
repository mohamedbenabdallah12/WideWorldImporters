using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackBI.Models;

public partial class DWContext : DbContext
{
    public DWContext()
    {
    }

    public DWContext(DbContextOptions<DWContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Date> Dates { get; set; }

    public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; }

    public virtual DbSet<DeliveryMethod1> DeliveryMethods1 { get; set; }

    public virtual DbSet<DestinationOleDb> DestinationOleDbs { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<PackageType> PackageTypes { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<StockItem> StockItems { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TransactionType> TransactionTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TULP000101\\MSSQLSERVER02;Database=Data;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityKey).HasName("PK__City__7327F6EF5BFC2B7E");

            entity.ToTable("City", "Dimension");

            entity.Property(e => e.CityKey)
                .ValueGeneratedNever()
                .HasColumnName("City key");
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.Continent).HasMaxLength(30);
            entity.Property(e => e.CountryName).HasMaxLength(60);
            entity.Property(e => e.LatestRecordedPopulation).HasColumnName("Latest Recorded Population");
            entity.Property(e => e.Region).HasMaxLength(30);
            entity.Property(e => e.SalesTerritory)
                .HasMaxLength(50)
                .HasColumnName("Sales Territory");
            entity.Property(e => e.StateProvince)
                .HasMaxLength(50)
                .HasColumnName("State Province");
            entity.Property(e => e.Subregion).HasMaxLength(30);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerKey).HasName("PK__Customer__CF62F14309B8A213");

            entity.ToTable("Customer", "Dimension");

            entity.Property(e => e.CustomerKey)
                .ValueGeneratedNever()
                .HasColumnName("Customer Key");
            entity.Property(e => e.AlternativePersonContact)
                .HasMaxLength(50)
                .HasColumnName("Alternative Person Contact");
            entity.Property(e => e.BillToCustomer).HasMaxLength(100);
            entity.Property(e => e.BuyingGroup)
                .HasMaxLength(50)
                .HasColumnName("Buying Group");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.DeliveryCity)
                .HasMaxLength(50)
                .HasColumnName("Delivery City");
            entity.Property(e => e.DeliveryMethodName)
                .HasMaxLength(50)
                .HasColumnName("Delivery Method Name");
            entity.Property(e => e.FaxNumber).HasMaxLength(20);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PostalCity)
                .HasMaxLength(50)
                .HasColumnName("Postal city");
            entity.Property(e => e.PrimaryContactPeerson)
                .HasMaxLength(50)
                .HasColumnName("Primary Contact Peerson");
        });

        modelBuilder.Entity<Date>(entity =>
        {
            entity.HasKey(e => e.Date1);

            entity.ToTable("Date", "Dimension");

            entity.Property(e => e.Date1)
                .HasColumnType("datetime")
                .HasColumnName("Date");
            entity.Property(e => e.CalendarMonthLabel)
                .HasMaxLength(20)
                .HasColumnName("Calendar Month Label");
            entity.Property(e => e.CalendarMonthNumber).HasColumnName("Calendar Month Number");
            entity.Property(e => e.CalendarYear).HasColumnName("Calendar Year");
            entity.Property(e => e.CalendarYearLabel)
                .HasMaxLength(10)
                .HasColumnName("Calendar Year Label");
            entity.Property(e => e.Day).HasMaxLength(10);
            entity.Property(e => e.DayNumber).HasColumnName("Day Number");
            entity.Property(e => e.FiscalMonthLabel)
                .HasMaxLength(20)
                .HasColumnName("Fiscal Month Label");
            entity.Property(e => e.FiscalMonthNumber).HasColumnName("Fiscal Month Number");
            entity.Property(e => e.FiscalYear).HasColumnName("Fiscal Year");
            entity.Property(e => e.FiscalYearLabel)
                .HasMaxLength(10)
                .HasColumnName("Fiscal Year Label");
            entity.Property(e => e.IsoWeekNumber).HasColumnName("ISO Week Number");
            entity.Property(e => e.Month).HasMaxLength(10);
            entity.Property(e => e.ShortMonth)
                .HasMaxLength(3)
                .HasColumnName("Short Month");
        });

        modelBuilder.Entity<DeliveryMethod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Delivery Method", "Dimension");

            entity.Property(e => e.DeliveryMethodId).HasColumnName("DeliveryMethodID");
            entity.Property(e => e.DeliveryMethodName).HasMaxLength(50);
        });

        modelBuilder.Entity<DeliveryMethod1>(entity =>
        {
            entity.HasKey(e => e.DeliveryMethodId).HasName("PK__Delivery__7B03A3A2EF58E8D4");

            entity.ToTable("Delivery Methods", "Dimension");

            entity.Property(e => e.DeliveryMethodId)
                .ValueGeneratedNever()
                .HasColumnName("DeliveryMethodID");
            entity.Property(e => e.DeliveryMethodName).HasMaxLength(50);
        });

        modelBuilder.Entity<DestinationOleDb>(entity =>
        {
            entity.HasKey(e => e.TransactionTypeKey).HasName("PK__Destinat__21EA35CE216F1F6A");

            entity.ToTable("Destination OLE DB");

            entity.Property(e => e.TransactionTypeKey)
                .ValueGeneratedNever()
                .HasColumnName("TransactionType Key");
            entity.Property(e => e.TransactionType).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Employee__AA2FFB85C198172F");

            entity.ToTable("Employee", "Dimension");

            entity.Property(e => e.PersonId)
                .ValueGeneratedNever()
                .HasColumnName("PersonID");
            entity.Property(e => e.EmailAddress).HasMaxLength(256);
            entity.Property(e => e.FaxNumber).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PreferredName).HasMaxLength(50);
        });

        modelBuilder.Entity<PackageType>(entity =>
        {
            entity.HasKey(e => e.PackageTypeId).HasName("PK__Package __0557DC70A86499EA");

            entity.ToTable("Package Type", "Dimension");

            entity.Property(e => e.PackageTypeId)
                .ValueGeneratedNever()
                .HasColumnName("PackageTypeID");
            entity.Property(e => e.PackageTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodKey).HasName("PK__Payment __E193177DE8A44152");

            entity.ToTable("Payment Method", "Dimension");

            entity.Property(e => e.PaymentMethodKey)
                .ValueGeneratedNever()
                .HasColumnName("PaymentMethod key");
            entity.Property(e => e.PaymentMethod1)
                .HasMaxLength(50)
                .HasColumnName("PaymentMethod");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sale", "Fact");

            entity.Property(e => e.BillToCustomerId).HasColumnName("BillToCustomerID");
            entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DeliveryDateKey)
                .HasColumnType("datetime")
                .HasColumnName("Delivery Date key");
            entity.Property(e => e.DeliveryMethodId).HasColumnName("DeliveryMethodID");
            entity.Property(e => e.DeliveryRun).HasMaxLength(5);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.ExtendedPrice).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InvoiceDateKey)
                .HasColumnType("datetime")
                .HasColumnName("Invoice Date Key");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.PackageTypeId).HasColumnName("PackageTypeID");
            entity.Property(e => e.Profit).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SalespersonPersonId).HasColumnName("SalespersonPersonID");
            entity.Property(e => e.StockItemId).HasColumnName("StockItemID");
            entity.Property(e => e.TaxAmount)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Tax Amount");
            entity.Property(e => e.TaxRate)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("Tax Rate");
            entity.Property(e => e.TotalChillerItems1)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Total Chiller Items");
            entity.Property(e => e.TotalDryItems1)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Total Dry Items");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Unit Price");

            entity.HasOne(d => d.BillToCustomer).WithMany()
                .HasForeignKey(d => d.BillToCustomerId)
                .HasConstraintName("FK_sale_Customer1");

            entity.HasOne(d => d.ContactPerson).WithMany()
                .HasForeignKey(d => d.ContactPersonId)
                .HasConstraintName("FK_sale_Employee");

            entity.HasOne(d => d.Customer).WithMany()
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_sale_Customer");

            entity.HasOne(d => d.DeliveryMethod).WithMany()
                .HasForeignKey(d => d.DeliveryMethodId)
                .HasConstraintName("FK_sale_Delivery Methods");

            entity.HasOne(d => d.InvoiceDateKeyNavigation).WithMany()
                .HasForeignKey(d => d.InvoiceDateKey)
                .HasConstraintName("FK_sale_Date");

            entity.HasOne(d => d.PackageType).WithMany()
                .HasForeignKey(d => d.PackageTypeId)
                .HasConstraintName("FK_sale_Package Type");

            entity.HasOne(d => d.SalespersonPerson).WithMany()
                .HasForeignKey(d => d.SalespersonPersonId)
                .HasConstraintName("FK_sale_Employee1");

            entity.HasOne(d => d.StockItem).WithMany()
                .HasForeignKey(d => d.StockItemId)
                .HasConstraintName("FK_sale_Stock Item");
        });

        modelBuilder.Entity<StockItem>(entity =>
        {
            entity.HasKey(e => e.StockItemKey).HasName("PK__Stock It__98DF8967A803962F");

            entity.ToTable("Stock Item", "Dimension");

            entity.Property(e => e.StockItemKey).ValueGeneratedNever();
            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.ColorName).HasMaxLength(20);
            entity.Property(e => e.LeadTimeDays).HasColumnName("Lead Time Days");
            entity.Property(e => e.OuterPackageTypeName).HasMaxLength(50);
            entity.Property(e => e.QuantityPerOuter).HasColumnName("Quantity Per Outer");
            entity.Property(e => e.RecommendedRetailPrice).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Size).HasMaxLength(20);
            entity.Property(e => e.StockItemName).HasMaxLength(100);
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.TaxRate).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypicalWeightPerUnit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.UnitPackageTypeName).HasMaxLength(50);
            entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE66694F24160DC");

            entity.ToTable("Supplier", "Dimension");

            entity.Property(e => e.SupplierId)
                .ValueGeneratedNever()
                .HasColumnName("SupplierID");
            entity.Property(e => e.FaxNumber).HasMaxLength(20);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PostalPostalCode).HasMaxLength(10);
            entity.Property(e => e.PrimaryContactName)
                .HasMaxLength(50)
                .HasColumnName("Primary Contact Name");
            entity.Property(e => e.SupplierCategoryName)
                .HasMaxLength(50)
                .HasColumnName("Supplier CategoryName");
            entity.Property(e => e.SupplierName).HasMaxLength(100);
        });

        modelBuilder.Entity<TransactionType>(entity =>
        {
            entity.HasKey(e => e.TransactionTypeKey).HasName("PK__Transact__21EA35CE8A66C673");

            entity.ToTable("Transaction Type", "Dimension");

            entity.Property(e => e.TransactionTypeKey)
                .ValueGeneratedNever()
                .HasColumnName("TransactionType Key");
            entity.Property(e => e.TransactionType1)
                .HasMaxLength(50)
                .HasColumnName("TransactionType");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
