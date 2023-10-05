using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataWarehouseApi.Models;

public partial class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbContext()
    {
    }

    public DbContext(DbContextOptions<DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApimLog> ApimLogs { get; set; }

    public virtual DbSet<AvgRequestTurnaroundByTenant> AvgRequestTurnaroundByTenants { get; set; }

    public virtual DbSet<BrApprover> BrApprovers { get; set; }

    public virtual DbSet<BrApprover1> BrApprovers1 { get; set; }

    public virtual DbSet<BrEmployeeApproval> BrEmployeeApprovals { get; set; }

    public virtual DbSet<BrEmployeeCompany> BrEmployeeCompanies { get; set; }

    public virtual DbSet<BrEmployeeRole> BrEmployeeRoles { get; set; }

    public virtual DbSet<BrGlaccountGroup> BrGlaccountGroups { get; set; }

    public virtual DbSet<BrItemBudget> BrItemBudgets { get; set; }

    public virtual DbSet<BrProxy> BrProxies { get; set; }

    public virtual DbSet<Configuration> Configurations { get; set; }

    public virtual DbSet<CurrentStateLabel> CurrentStateLabels { get; set; }

    public virtual DbSet<DimApproval> DimApprovals { get; set; }

    public virtual DbSet<DimApproval1> DimApprovals1 { get; set; }

    public virtual DbSet<DimCompany> DimCompanies { get; set; }

    public virtual DbSet<DimCompany1> DimCompanies1 { get; set; }

    public virtual DbSet<DimCurrency> DimCurrencies { get; set; }

    public virtual DbSet<DimCurrency1> DimCurrencies1 { get; set; }

    public virtual DbSet<DimEmployee> DimEmployees { get; set; }

    public virtual DbSet<DimEmployee1> DimEmployees1 { get; set; }

    public virtual DbSet<DimExchangeRate> DimExchangeRates { get; set; }

    public virtual DbSet<DimExchangeRate1> DimExchangeRates1 { get; set; }

    public virtual DbSet<DimFinancialPeriod> DimFinancialPeriods { get; set; }

    public virtual DbSet<DimFinancialPeriod1> DimFinancialPeriods1 { get; set; }

    public virtual DbSet<DimGlaccount> DimGlaccounts { get; set; }

    public virtual DbSet<DimGlaccount1> DimGlaccounts1 { get; set; }

    public virtual DbSet<DimHoliday> DimHolidays { get; set; }

    public virtual DbSet<DimLocation> DimLocations { get; set; }

    public virtual DbSet<DimRole> DimRoles { get; set; }

    public virtual DbSet<DimSupplier> DimSuppliers { get; set; }

    public virtual DbSet<DimSupplier1> DimSuppliers1 { get; set; }

    public virtual DbSet<EmployeeCompany> EmployeeCompanies { get; set; }

    public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }

    public virtual DbSet<ExtSpendViewFactRequestItemExternal> ExtSpendViewFactRequestItemExternals { get; set; }

    public virtual DbSet<FactAlert> FactAlerts { get; set; }

    public virtual DbSet<FactAlert1> FactAlerts1 { get; set; }

    public virtual DbSet<FactApproval> FactApprovals { get; set; }

    public virtual DbSet<FactApproval1> FactApprovals1 { get; set; }

    public virtual DbSet<FactApprovalHistory> FactApprovalHistories { get; set; }

    public virtual DbSet<FactBudget> FactBudgets { get; set; }

    public virtual DbSet<FactBudget1> FactBudgets1 { get; set; }

    public virtual DbSet<FactEmployeeCompanyChangeHistory> FactEmployeeCompanyChangeHistories { get; set; }

    public virtual DbSet<FactEmployeeRoleHistory> FactEmployeeRoleHistories { get; set; }

    public virtual DbSet<FactEmployeeRoleHistory1> FactEmployeeRoleHistories1 { get; set; }

    public virtual DbSet<FactInvoice> FactInvoices { get; set; }

    public virtual DbSet<FactInvoice1> FactInvoices1 { get; set; }

    public virtual DbSet<FactInvoiceItem> FactInvoiceItems { get; set; }

    public virtual DbSet<FactPurchaseOrder> FactPurchaseOrders { get; set; }

    public virtual DbSet<FactPurchaseOrder1> FactPurchaseOrders1 { get; set; }

    public virtual DbSet<FactReceipt> FactReceipts { get; set; }

    public virtual DbSet<FactReceipt1> FactReceipts1 { get; set; }

    public virtual DbSet<FactRequest> FactRequests { get; set; }

    public virtual DbSet<FactRequest1> FactRequests1 { get; set; }

    public virtual DbSet<FactRequestItem> FactRequestItems { get; set; }

    public virtual DbSet<FactRequestStateHistory> FactRequestStateHistories { get; set; }

    public virtual DbSet<FinancialPeriodDate> FinancialPeriodDates { get; set; }

    public virtual DbSet<InvoiceExtractionLog> InvoiceExtractionLogs { get; set; }

    public virtual DbSet<MonthlyRequestToPurchasePercentileBenchmark> MonthlyRequestToPurchasePercentileBenchmarks { get; set; }

    public virtual DbSet<PopulationRequestTurnaroundPercentile> PopulationRequestTurnaroundPercentiles { get; set; }

    public virtual DbSet<RequestStateHistory> RequestStateHistories { get; set; }

    public virtual DbSet<RequestToPurchasePercentileBenchmark> RequestToPurchasePercentileBenchmarks { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<StoredProcedure> StoredProcedures { get; set; }

    public virtual DbSet<TenantMonthlyRequestToPurchasePercentileBenchmark> TenantMonthlyRequestToPurchasePercentileBenchmarks { get; set; }

    public virtual DbSet<TenantOutlier> TenantOutliers { get; set; }

    public virtual DbSet<TenantRequestToPurchasePercentileBenchmark> TenantRequestToPurchasePercentileBenchmarks { get; set; }

    public virtual DbSet<TenantRequestTurnaroundPercentile> TenantRequestTurnaroundPercentiles { get; set; }

    public virtual DbSet<TenantUrl> TenantUrls { get; set; }

    public virtual DbSet<Watermark> Watermarks { get; set; }

    public virtual DbSet<WatermarkSptoSp> WatermarkSptoSps { get; set; }

    public virtual DbSet<WatermarkTableToSp> WatermarkTableToSps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=eudwsqlserver.database.windows.net;Database=testDWDB;User Id=Fxdatafactory;password=AE9oKdiY&!#6k@;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApimLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ApimLogs", "log");
        });

        modelBuilder.Entity<AvgRequestTurnaroundByTenant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AvgRequestTurnaroundByTenant", "benchmark");

            entity.Property(e => e.Fxtenantid).HasColumnName("fxtenantid");
        });

        modelBuilder.Entity<BrApprover>(entity =>
        {
            entity.HasKey(e => new { e.DimEmployeeId, e.DimApprovalId });

            entity.ToTable("BrApprover");

            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.DimApprovalId).HasColumnName("DimApprovalID");
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.ApproverId).HasColumnName("ApproverID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<BrApprover1>(entity =>
        {
            entity.HasKey(e => new { e.ApproverId, e.DataSource });

            entity.ToTable("BrApprover", "stg");

            entity.Property(e => e.ApproverId).HasColumnName("ApproverID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<BrEmployeeApproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BrEmployeeApproval");

            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.ApproverId).HasColumnName("ApproverID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(52)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TypeName).HasMaxLength(40);
        });

        modelBuilder.Entity<BrEmployeeCompany>(entity =>
        {
            entity.HasKey(e => new { e.DimEmployeeId, e.DimCompanyId });

            entity.ToTable("BrEmployeeCompany");

            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.DimCompanyId).HasColumnName("DimCompanyID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DataSource).HasMaxLength(250);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.FxUserId).HasColumnName("FxUserID");
        });

        modelBuilder.Entity<BrEmployeeRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BrEmployeeRole");

            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.DimRoleId).HasColumnName("DimRoleID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
        });

        modelBuilder.Entity<BrGlaccountGroup>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.DimGlaccountId });

            entity.ToTable("BrGLAccountGroup");

            entity.HasIndex(e => e.DimGlaccountId, "IX_BrGLAccountGroup_DimGLAccountID");

            entity.HasIndex(e => new { e.RequestItemId, e.DataSource }, "IX_BrGLAccountGroup_RequestItemID_DataSource");

            entity.HasIndex(e => e.RequestItemId, "IX_BrGLAccountGroup_RequestItemID_GroupID");

            entity.HasIndex(e => new { e.RequestItemId, e.InvoiceItemId }, "IX_BrGLAccountGroup_RequestItemID_InvoiceItemID");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.DimGlaccountId).HasColumnName("DimGLAccountID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceItemId).HasColumnName("InvoiceItemID");
            entity.Property(e => e.RequestItemId).HasColumnName("RequestItemID");
        });

        modelBuilder.Entity<BrItemBudget>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BrItemBudget", "stg");

            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountID");
            entity.Property(e => e.GlsegmentId).HasColumnName("GLSegmentID");
            entity.Property(e => e.InvoiceItemId).HasColumnName("InvoiceItemID");
            entity.Property(e => e.RequestItemId).HasColumnName("RequestItemID");
        });

        modelBuilder.Entity<BrProxy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BrProxy");

            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.DimProxyId).HasColumnName("DimProxyID");
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Configuration");

            entity.Property(e => e.ExtDatabaseName).HasMaxLength(50);
            entity.Property(e => e.ExtServerName).HasMaxLength(50);
        });

        modelBuilder.Entity<CurrentStateLabel>(entity =>
        {
            entity.HasKey(e => e.CurrentStateId);

            entity.ToTable("CurrentStateLabels", "stg");

            entity.Property(e => e.CurrentStateId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CurrentStateID");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResourceName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DimApproval>(entity =>
        {
            entity.HasKey(e => e.DimApprovalId)
                .HasName("PK_Approval")
                .IsClustered(false);

            entity.ToTable("DimApproval");

            entity.HasIndex(e => new { e.TenantId, e.ApprovalId }, "IX_Approval0").IsClustered();

            entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_Approval1");

            entity.HasIndex(e => new { e.IsRequest, e.IsInvoice, e.IsSupplier, e.IsActive }, "IX_Approval2");

            entity.Property(e => e.DimApprovalId).HasColumnName("DimApprovalID");
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.Name).HasMaxLength(80);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<DimApproval1>(entity =>
        {
            entity.HasKey(e => new { e.ApprovalId, e.DataSource }).IsClustered(false);

            entity.ToTable("DimApproval", "stg");

            entity.HasIndex(e => new { e.TenantId, e.ApprovalId }, "IX_Approval0").IsClustered();

            entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_Approval1");

            entity.HasIndex(e => new { e.IsRequest, e.IsInvoice, e.IsSupplier, e.IsActive }, "IX_Approval2");

            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(80);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<DimCompany>(entity =>
        {
            entity.ToTable("DimCompany");

            entity.HasIndex(e => e.CompanyId, "IX_DimCompany_CompanyID");

            entity.HasIndex(e => e.DataSource, "IX_DimCompany_DataSource");

            entity.HasIndex(e => e.DimReportingCurrencyId, "IX_DimCompany_DimReportingCurrencyID");

            entity.HasIndex(e => e.FxTenantId, "IX_DimCompany_FxTenantID");

            entity.HasIndex(e => new { e.TenantId, e.DataSource }, "IX_DimCompany_TenantID");

            entity.Property(e => e.DimCompanyId).HasColumnName("DimCompanyID");
            entity.Property(e => e.AadtenantId).HasColumnName("AADTenantID");
            entity.Property(e => e.CompanyCode).HasMaxLength(20);
            entity.Property(e => e.CompanyCurrencyId).HasColumnName("CompanyCurrencyID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(80);
            entity.Property(e => e.CompanyRegistrationNumber).HasMaxLength(40);
            entity.Property(e => e.CompanyTaxRegistrationNumber).HasMaxLength(40);
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DimCurrencyId).HasColumnName("DimCurrencyID");
            entity.Property(e => e.DimReportingCurrencyId).HasColumnName("DimReportingCurrencyID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.ReportingCurrencyId).HasColumnName("ReportingCurrencyID");
            entity.Property(e => e.TenantCancelledDate).HasColumnType("datetime");
            entity.Property(e => e.TenantCode).HasMaxLength(20);
            entity.Property(e => e.TenantCreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TenantEmail).HasMaxLength(256);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TenantLoginName).HasMaxLength(30);
            entity.Property(e => e.TenantName).HasMaxLength(80);
            entity.Property(e => e.TenantShortName).HasMaxLength(20);
            entity.Property(e => e.WebsiteUrl)
                .HasMaxLength(256)
                .HasColumnName("WebsiteURL");
        });

        modelBuilder.Entity<DimCompany1>(entity =>
        {
            entity.HasKey(e => new { e.CompanyId, e.DataSource, e.TenantId });

            entity.ToTable("DimCompany", "stg");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.AadtenantId).HasColumnName("AADTenantID");
            entity.Property(e => e.CompanyCode).HasMaxLength(20);
            entity.Property(e => e.CompanyCurrencyId).HasColumnName("CompanyCurrencyID");
            entity.Property(e => e.CompanyName).HasMaxLength(80);
            entity.Property(e => e.CompanyPoreferenceMask)
                .HasMaxLength(40)
                .HasColumnName("CompanyPOReferenceMask");
            entity.Property(e => e.CompanyRegistrationNumber).HasMaxLength(40);
            entity.Property(e => e.CompanyTaxRegistrationNumber).HasMaxLength(40);
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.ReportingCurrencyId).HasColumnName("ReportingCurrencyID");
            entity.Property(e => e.TenantCancelledDate).HasColumnType("datetime");
            entity.Property(e => e.TenantCode).HasMaxLength(20);
            entity.Property(e => e.TenantCreationDate).HasColumnType("datetime");
            entity.Property(e => e.TenantEmail).HasMaxLength(256);
            entity.Property(e => e.TenantLoginName).HasMaxLength(30);
            entity.Property(e => e.TenantName).HasMaxLength(80);
            entity.Property(e => e.TenantShortName).HasMaxLength(20);
        });

        modelBuilder.Entity<DimCurrency>(entity =>
        {
            entity.ToTable("DimCurrency");

            entity.Property(e => e.DimCurrencyId).HasColumnName("DimCurrencyID");
            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.Name).HasMaxLength(80);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<DimCurrency1>(entity =>
        {
            entity.HasKey(e => new { e.CurrencyId, e.TenantId, e.DataSource });

            entity.ToTable("DimCurrency", "stg");

            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(80);
        });

        modelBuilder.Entity<DimEmployee>(entity =>
        {
            entity.ToTable("DimEmployee");

            entity.HasIndex(e => e.EmployeeId, "IX_DimEmployee_EmployeeID");

            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.AaduserId).HasColumnName("AADUserID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DefaultCompanyId).HasColumnName("DefaultCompanyID");
            entity.Property(e => e.DefaultInvoiceLocationId).HasColumnName("DefaultInvoiceLocationID");
            entity.Property(e => e.DefaultPhysicalLocationId).HasColumnName("DefaultPhysicalLocationID");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeRef).HasMaxLength(40);
            entity.Property(e => e.FirstName).HasMaxLength(256);
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.FxUserId).HasColumnName("FxUserID");
            entity.Property(e => e.LastName).HasMaxLength(256);
            entity.Property(e => e.LdapuserId)
                .HasMaxLength(80)
                .HasColumnName("LDAPUserID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.TimeZoneId)
                .HasMaxLength(40)
                .HasColumnName("TimeZoneID");
        });

        modelBuilder.Entity<DimEmployee1>(entity =>
        {
            entity.HasKey(e => new { e.EmployeeId, e.TenantId, e.DataSource });

            entity.ToTable("DimEmployee", "stg");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AaduserId).HasColumnName("AADUserID");
            entity.Property(e => e.DefaultCompanyId).HasColumnName("DefaultCompanyID");
            entity.Property(e => e.DefaultInvoiceLocationId).HasColumnName("DefaultInvoiceLocationID");
            entity.Property(e => e.DefaultPhysicalLocationId).HasColumnName("DefaultPhysicalLocationID");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EmployeeRef).HasMaxLength(40);
            entity.Property(e => e.FirstName).HasMaxLength(256);
            entity.Property(e => e.FxUserId).HasColumnName("FxUserID");
            entity.Property(e => e.LastName).HasMaxLength(256);
            entity.Property(e => e.LdapuserId)
                .HasMaxLength(80)
                .HasColumnName("LDAPUserID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.TimeZoneId)
                .HasMaxLength(40)
                .HasColumnName("TimeZoneID");
        });

        modelBuilder.Entity<DimExchangeRate>(entity =>
        {
            entity.ToTable("DimExchangeRate");

            entity.HasIndex(e => e.DataSource, "IX_DimExchangeRate_DataSource");

            entity.HasIndex(e => e.TenantId, "IX_DimExchangeRate_TenantID");

            entity.Property(e => e.DimExchangeRateId).HasColumnName("DimExchangeRateID");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DestinationCurrencyId).HasColumnName("DestinationCurrencyID");
            entity.Property(e => e.DimDestinationCurrencyId).HasColumnName("DimDestinationCurrencyID");
            entity.Property(e => e.DimSourceCurrencyId).HasColumnName("DimSourceCurrencyID");
            entity.Property(e => e.ExchangeRateId).HasColumnName("ExchangeRateID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Type).HasMaxLength(40);
            entity.Property(e => e.Value).HasColumnType("decimal(18, 9)");
        });

        modelBuilder.Entity<DimExchangeRate1>(entity =>
        {
            entity.HasKey(e => new { e.ExchangeRateId, e.TenantId, e.DataSource });

            entity.ToTable("DimExchangeRate", "stg");

            entity.Property(e => e.ExchangeRateId).HasColumnName("ExchangeRateID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.DestinationCurrencyId).HasColumnName("DestinationCurrencyID");
            entity.Property(e => e.Type).HasMaxLength(40);
            entity.Property(e => e.Value).HasColumnType("decimal(18, 9)");
        });

        modelBuilder.Entity<DimFinancialPeriod>(entity =>
        {
            entity.ToTable("DimFinancialPeriod");

            entity.HasIndex(e => e.DimFinancialPeriodId, "IX_DimFinancialPeriod");

            entity.HasIndex(e => e.FinancialPeriodId, "IX_DimFinancialPeriod_FinancialPeriodID");

            entity.HasIndex(e => e.FinancialYearId, "IX_DimFinancialPeriod_FinancialYearID");

            entity.Property(e => e.DimFinancialPeriodId).HasColumnName("DimFinancialPeriodID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(80);
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.FinancialPeriodId).HasColumnName("FinancialPeriodID");
            entity.Property(e => e.FinancialYearDescription).HasMaxLength(80);
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<DimFinancialPeriod1>(entity =>
        {
            entity.HasKey(e => new { e.FinancialPeriodId, e.DataSource });

            entity.ToTable("DimFinancialPeriod", "stg");

            entity.Property(e => e.FinancialPeriodId).HasColumnName("FinancialPeriodID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(80);
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.FinancialYearDescription).HasMaxLength(80);
            entity.Property(e => e.FinancialYearId).HasColumnName("FinancialYearID");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<DimGlaccount>(entity =>
        {
            entity.ToTable("DimGLAccount");

            entity.HasIndex(e => e.GlaccountId, "IX_DimGLAccount_GLAccountID");

            entity.Property(e => e.DimGlaccountId).HasColumnName("DimGLAccountID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DimCompanyId).HasColumnName("DimCompanyID");
            entity.Property(e => e.FullName).HasMaxLength(1000);
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountID");
            entity.Property(e => e.Glcode)
                .HasMaxLength(1000)
                .HasColumnName("GLCode");
            entity.Property(e => e.GlcodeMaskId).HasColumnName("GLCodeMaskID");
            entity.Property(e => e.Name).HasMaxLength(1000);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<DimGlaccount1>(entity =>
        {
            entity.HasKey(e => new { e.GlaccountId, e.DataSource });

            entity.ToTable("DimGLAccount", "stg");

            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.FullName).HasMaxLength(1000);
            entity.Property(e => e.Glcode)
                .HasMaxLength(1000)
                .HasColumnName("GLCode");
            entity.Property(e => e.GlcodeMaskId).HasColumnName("GLCodeMaskID");
            entity.Property(e => e.Name).HasMaxLength(1000);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<DimHoliday>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DimHoliday");

            entity.HasIndex(e => e.TheDate, "CIX_DimHoliday").IsClustered();

            entity.Property(e => e.HolidayText).HasMaxLength(255);
            entity.Property(e => e.TheDate).HasColumnType("date");
        });

        modelBuilder.Entity<DimLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DimLocation");

            entity.Property(e => e.Address1).HasMaxLength(80);
            entity.Property(e => e.Address2).HasMaxLength(80);
            entity.Property(e => e.Address3).HasMaxLength(80);
            entity.Property(e => e.Address4).HasMaxLength(80);
            entity.Property(e => e.Contact).HasMaxLength(40);
            entity.Property(e => e.Coordinates).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(60);
            entity.Property(e => e.DataSource)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.DimLocationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DimLocationID");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FaxNumber).HasMaxLength(20);
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.Locality).HasMaxLength(80);
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Region).HasMaxLength(80);
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<DimRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DimRole");

            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DimRoleId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DimRoleID");
            entity.Property(e => e.ResourceName).HasMaxLength(40);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
        });

        modelBuilder.Entity<DimSupplier>(entity =>
        {
            entity.ToTable("DimSupplier");

            entity.HasIndex(e => e.SupplierId, "IX_SupplierID");

            entity.Property(e => e.DimSupplierId).HasColumnName("DimSupplierID");
            entity.Property(e => e.Address1).HasMaxLength(80);
            entity.Property(e => e.Address2).HasMaxLength(80);
            entity.Property(e => e.Address3).HasMaxLength(80);
            entity.Property(e => e.Address4).HasMaxLength(80);
            entity.Property(e => e.CategoryId1).HasColumnName("CategoryID1");
            entity.Property(e => e.CategoryId2).HasColumnName("CategoryID2");
            entity.Property(e => e.CategoryId3).HasColumnName("CategoryID3");
            entity.Property(e => e.Code).HasMaxLength(52);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Contact).HasMaxLength(40);
            entity.Property(e => e.Coordinates).HasMaxLength(60);
            entity.Property(e => e.Country).HasMaxLength(80);
            entity.Property(e => e.CustomColumns).HasColumnType("xml");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FaxNumber).HasMaxLength(20);
            entity.Property(e => e.FxSupplierId).HasColumnName("FxSupplierID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.Locality).HasMaxLength(80);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PaymentTerms).HasMaxLength(60);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Region).HasMaxLength(80);
            entity.Property(e => e.RegistrationNumber).HasMaxLength(50);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.TaxRegistrationNumber).HasMaxLength(50);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<DimSupplier1>(entity =>
        {
            entity.HasKey(e => new { e.SupplierId, e.DataSource });

            entity.ToTable("DimSupplier", "stg");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Address1).HasMaxLength(80);
            entity.Property(e => e.Address2).HasMaxLength(80);
            entity.Property(e => e.Address3).HasMaxLength(80);
            entity.Property(e => e.Address4).HasMaxLength(80);
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.BankAccountNumber).HasMaxLength(50);
            entity.Property(e => e.BankingInfo).HasMaxLength(256);
            entity.Property(e => e.CategoryId1).HasColumnName("CategoryID1");
            entity.Property(e => e.CategoryId2).HasColumnName("CategoryID2");
            entity.Property(e => e.CategoryId3).HasColumnName("CategoryID3");
            entity.Property(e => e.Code).HasMaxLength(52);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Contact).HasMaxLength(40);
            entity.Property(e => e.Coordinates).HasMaxLength(60);
            entity.Property(e => e.Country).HasMaxLength(80);
            entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.CustomColumns).HasColumnType("xml");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FaxNumber).HasMaxLength(20);
            entity.Property(e => e.FxSupplierId).HasColumnName("FxSupplierID");
            entity.Property(e => e.Locality).HasMaxLength(80);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PaymentTerms).HasMaxLength(60);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Region).HasMaxLength(80);
            entity.Property(e => e.RegistrationNumber).HasMaxLength(50);
            entity.Property(e => e.TaxRegistrationNumber).HasMaxLength(50);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<EmployeeCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeCompany", "stg");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DataSource).HasMaxLength(250);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
        });

        modelBuilder.Entity<EmployeeRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeRole", "stg");

            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
        });

        modelBuilder.Entity<ExtSpendViewFactRequestItemExternal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("extSpend_viewFactRequestItemExternal");

            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ExclItemCost).HasColumnType("money");
            entity.Property(e => e.ExclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.ExclUnitCost).HasColumnType("money");
            entity.Property(e => e.ExclUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.InclItemCost).HasColumnType("money");
            entity.Property(e => e.InclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.InclUnitCost).HasColumnType("money");
            entity.Property(e => e.InclUnitCostSrc).HasColumnType("decimal(38, 14)");
            entity.Property(e => e.ItemTax).HasColumnType("money");
            entity.Property(e => e.ItemTaxSrc).HasColumnType("money");
            entity.Property(e => e.RequestAssistantId).HasColumnName("RequestAssistantID");
            entity.Property(e => e.RequestCurrentStateId).HasColumnName("RequestCurrentStateID");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.RequestItemApprovalId).HasColumnName("RequestItemApprovalID");
            entity.Property(e => e.RequestItemCurrencyId).HasColumnName("RequestItemCurrencyID");
            entity.Property(e => e.RequestItemDateStamp).HasColumnType("date");
            entity.Property(e => e.RequestItemDeliveryLocationId).HasColumnName("RequestItemDeliveryLocationID");
            entity.Property(e => e.RequestItemDescription).HasMaxLength(120);
            entity.Property(e => e.RequestItemExchangeRate).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.RequestItemId).HasColumnName("RequestItemID");
            entity.Property(e => e.RequestItemQuantity).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.RequestItemRequestorId).HasColumnName("RequestItemRequestorID");
            entity.Property(e => e.RequestItemServiceSupplierId).HasColumnName("RequestItemServiceSupplierID");
            entity.Property(e => e.RequestItemSupplierId).HasColumnName("RequestItemSupplierID");
            entity.Property(e => e.RequestItemTaxAmount).HasColumnType("money");
            entity.Property(e => e.RequestItemTaxRateId).HasColumnName("RequestItemTaxRateID");
            entity.Property(e => e.RequestItemTypeBaseResourceName).HasMaxLength(40);
            entity.Property(e => e.RequestItemTypeId).HasColumnName("RequestItemTypeID");
            entity.Property(e => e.RequestItemUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.RequestRequestorId).HasColumnName("RequestRequestorID");
            entity.Property(e => e.RequestTitle).HasMaxLength(80);
            entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitTax).HasColumnType("money");
            entity.Property(e => e.UnitTaxSrc).HasColumnType("money");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FactAlert>(entity =>
        {
            entity.ToTable("FactAlert");

            entity.Property(e => e.FactAlertId).HasColumnName("FactAlertID");
            entity.Property(e => e.AcknowledgedById).HasColumnName("AcknowledgedByID");
            entity.Property(e => e.AcknowledgedDate).HasColumnType("datetime");
            entity.Property(e => e.AlertCreationDate).HasColumnType("datetime");
            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.AlertInfo).HasMaxLength(1024);
            entity.Property(e => e.AlertPolicyDescription).HasMaxLength(80);
            entity.Property(e => e.AlertPolicyId).HasColumnName("AlertPolicyID");
            entity.Property(e => e.AlertRecipientCreationDate).HasColumnType("datetime");
            entity.Property(e => e.AlertRecipientId).HasColumnName("AlertRecipientID");
            entity.Property(e => e.AlertTypeName).HasMaxLength(40);
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.ProformaInvoiceId).HasColumnName("ProformaInvoiceID");
            entity.Property(e => e.RecipientId).HasColumnName("RecipientID");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<FactAlert1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FactAlert", "stg");

            entity.Property(e => e.AcknowledgedById).HasColumnName("AcknowledgedByID");
            entity.Property(e => e.AcknowledgedDate).HasColumnType("datetime");
            entity.Property(e => e.AlertCreationDate).HasColumnType("datetime");
            entity.Property(e => e.AlertId).HasColumnName("AlertID");
            entity.Property(e => e.AlertInfo).HasMaxLength(1024);
            entity.Property(e => e.AlertPolicyDescription).HasMaxLength(80);
            entity.Property(e => e.AlertPolicyId).HasColumnName("AlertPolicyID");
            entity.Property(e => e.AlertRecipientCreationDate).HasColumnType("datetime");
            entity.Property(e => e.AlertRecipientId).HasColumnName("AlertRecipientID");
            entity.Property(e => e.AlertTypeName).HasMaxLength(40);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.ProformaInvoiceId).HasColumnName("ProformaInvoiceID");
            entity.Property(e => e.RecipientId).HasColumnName("RecipientID");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<FactApproval>(entity =>
        {
            entity.ToTable("FactApproval");

            entity.HasIndex(e => e.DataSource, "IX_FactApproval_DataSource");

            entity.HasIndex(e => e.InvoiceId, "IX_FactApproval_InvoiceID");

            entity.HasIndex(e => new { e.RequestId, e.DataSource }, "IX_FactApproval_RequestID");

            entity.Property(e => e.FactApprovalId).HasColumnName("FactApprovalID");
            entity.Property(e => e.Approval).HasMaxLength(40);
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateStamp).HasColumnType("datetime");
            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.Employee).HasMaxLength(513);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.UserAction).HasMaxLength(40);
        });

        modelBuilder.Entity<FactApproval1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FactApproval", "stg");

            entity.Property(e => e.Approval).HasMaxLength(40);
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateStamp).HasColumnType("datetime");
            entity.Property(e => e.Employee).HasMaxLength(513);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.UserAction).HasMaxLength(40);
        });

        modelBuilder.Entity<FactApprovalHistory>(entity =>
        {
            entity.ToTable("FactApprovalHistory");

            entity.Property(e => e.FactApprovalHistoryId).HasColumnName("FactApprovalHistoryID");
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.DateStamp).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.Info).HasMaxLength(256);
            entity.Property(e => e.Note).HasMaxLength(256);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.UserAction).HasMaxLength(40);
        });

        modelBuilder.Entity<FactBudget>(entity =>
        {
            entity.ToTable("FactBudget");

            entity.Property(e => e.FactBudgetId).HasColumnName("FactBudgetID");
            entity.Property(e => e.ActualSpend).HasColumnType("money");
            entity.Property(e => e.BudgetId).HasColumnName("BudgetID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DimFinancialPeriodId).HasColumnName("DimFinancialPeriodID");
            entity.Property(e => e.DimGlaccountId).HasColumnName("DimGLAccountID");
            entity.Property(e => e.FinancialPeriodId).HasColumnName("FinancialPeriodID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountID");
            entity.Property(e => e.GlsegmentId).HasColumnName("GLSegmentID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Value).HasColumnType("money");
        });

        modelBuilder.Entity<FactBudget1>(entity =>
        {
            entity.HasKey(e => new { e.BudgetId, e.TenantId, e.DataSource });

            entity.ToTable("FactBudget", "stg");

            entity.Property(e => e.BudgetId).HasColumnName("BudgetID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ActualSpend).HasColumnType("money");
            entity.Property(e => e.FinancialPeriodId).HasColumnName("FinancialPeriodID");
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountID");
            entity.Property(e => e.GlsegmentId).HasColumnName("GLSegmentID");
            entity.Property(e => e.Value).HasColumnType("money");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FactEmployeeCompanyChangeHistory>(entity =>
        {
            entity.ToTable("FactEmployeeCompanyChangeHistory");

            entity.Property(e => e.FactEmployeeCompanyChangeHistoryId).HasColumnName("FactEmployeeCompanyChangeHistoryID");
            entity.Property(e => e.Action)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.DateStamp).HasColumnType("date");
            entity.Property(e => e.DateTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.DimCompanyId).HasColumnName("DimCompanyID");
            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
        });

        modelBuilder.Entity<FactEmployeeRoleHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FactEmployeeRoleHistory");

            entity.HasIndex(e => new { e.DimEmployeeId, e.DateStamp, e.DimRoleId }, "IX_FactEmployeeRoleHistory_DimEmployeeID_DateStamp_DimRoleID");

            entity.Property(e => e.CurrentUserId).HasColumnName("CurrentUserID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateStamp).HasColumnType("datetime");
            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.DimRoleId).HasColumnName("DimRoleID");
            entity.Property(e => e.EmployeeHistoryId).HasColumnName("EmployeeHistoryID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FactEmployeeRoleHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FactEmployeeRoleHistoryID");
        });

        modelBuilder.Entity<FactEmployeeRoleHistory1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FactEmployeeRoleHistory", "stg");

            entity.Property(e => e.CurrentUserId).HasColumnName("CurrentUserID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateStamp).HasColumnType("datetime");
            entity.Property(e => e.EmployeeHistoryId).HasColumnName("EmployeeHistoryID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.UserAction).HasMaxLength(40);
            entity.Property(e => e.Value).IsUnicode(false);
        });

        modelBuilder.Entity<FactInvoice>(entity =>
        {
            entity.ToTable("FactInvoice");

            entity.HasIndex(e => e.ApprovalId, "IX_FactInvoice_ApprovalID");

            entity.HasIndex(e => e.CurrentStateId, "IX_FactInvoice_CurrentStateID");

            entity.HasIndex(e => e.DataSource, "IX_FactInvoice_DataSource");

            entity.HasIndex(e => e.DimCompanyId, "IX_FactInvoice_DimCompanyID");

            entity.HasIndex(e => e.InvoiceDate, "IX_FactInvoice_InvoiceDate");

            entity.HasIndex(e => e.InvoiceId, "IX_FactInvoice_InvoiceID_dbo");

            entity.HasIndex(e => e.InvoiceItemId, "IX_FactInvoice_InvoiceItemID");

            entity.HasIndex(e => e.Poid, "IX_FactInvoice_POID");

            entity.HasIndex(e => e.PoitemId, "IX_FactInvoice_POItemID");

            entity.HasIndex(e => e.TenantId, "IX_FactInvoice_TenantID");

            entity.Property(e => e.FactInvoiceId).HasColumnName("FactInvoiceID");
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.ApproveAt).HasColumnType("datetime");
            entity.Property(e => e.ApproveCcat)
                .HasColumnType("datetime")
                .HasColumnName("ApproveCCAt");
            entity.Property(e => e.ClosedAt).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CurrentState).HasMaxLength(40);
            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DaysFromPotoInvoice).HasColumnName("DaysFromPOToInvoice");
            entity.Property(e => e.DaysFromRequestToPo).HasColumnName("DaysFromRequestToPO");
            entity.Property(e => e.DimApprovalId).HasColumnName("DimApprovalID");
            entity.Property(e => e.DimCompanyId).HasColumnName("DimCompanyID");
            entity.Property(e => e.DimCurrencyId).HasColumnName("DimCurrencyID");
            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.DimSupplierId).HasColumnName("DimSupplierID");
            entity.Property(e => e.ExInvoiceRef).HasMaxLength(40);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.ExclItemCost).HasColumnType("money");
            entity.Property(e => e.ExclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.ExclUnitCost).HasColumnType("money");
            entity.Property(e => e.ExclUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.GlaccountGroupId).HasColumnName("GLAccountGroupID");
            entity.Property(e => e.InclItemCost).HasColumnType("money");
            entity.Property(e => e.InclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.InclUnitCost).HasColumnType("money");
            entity.Property(e => e.InclUnitCostSrc).HasColumnType("decimal(38, 14)");
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceItemDescription).HasMaxLength(120);
            entity.Property(e => e.InvoiceItemId).HasColumnName("InvoiceItemID");
            entity.Property(e => e.InvoiceItemQuantity).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.InvoiceMpId).HasColumnName("InvoiceMpID");
            entity.Property(e => e.InvoiceRef).HasMaxLength(40);
            entity.Property(e => e.ItemTax).HasColumnType("money");
            entity.Property(e => e.ItemTaxSrc).HasColumnType("money");
            entity.Property(e => e.ItemTaxTotal).HasColumnType("money");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.PoitemId).HasColumnName("POItemID");
            entity.Property(e => e.PostingDate).HasColumnType("date");
            entity.Property(e => e.PreApproveAt).HasColumnType("datetime");
            entity.Property(e => e.PreApproveCcat)
                .HasColumnType("datetime")
                .HasColumnName("PreApproveCCAt");
            entity.Property(e => e.ProcessorId).HasColumnName("ProcessorID");
            entity.Property(e => e.QuotePendingAt).HasColumnType("datetime");
            entity.Property(e => e.RequestItemTypeId).HasColumnName("RequestItemTypeID");
            entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitCostSrc).HasColumnType("money");
            entity.Property(e => e.UnitTax).HasColumnType("money");
            entity.Property(e => e.UnitTaxSrc).HasColumnType("money");
        });

        modelBuilder.Entity<FactInvoice1>(entity =>
        {
            entity.HasKey(e => new { e.InvoiceItemId, e.InvoiceId, e.DataSource });

            entity.ToTable("FactInvoice", "stg");

            entity.HasIndex(e => e.InvoiceItemId, "IX_FactInvoice");

            entity.HasIndex(e => e.CompanyId, "IX_FactInvoice_CompanyID");

            entity.HasIndex(e => e.InvoiceId, "IX_FactInvoice_InvoiceID");

            entity.HasIndex(e => e.InvoiceItemId, "IX_FactInvoice_InvoiceItemID");

            entity.HasIndex(e => e.Poid, "IX_FactInvoice_POID");

            entity.HasIndex(e => e.PoitemId, "IX_FactInvoice_POItemID");

            entity.HasIndex(e => e.ProcessorId, "IX_FactInvoice_ProcessorID");

            entity.HasIndex(e => e.SupplierId, "IX_FactInvoice_SupplierID");

            entity.Property(e => e.InvoiceItemId).HasColumnName("InvoiceItemID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.ApproveAt).HasColumnType("datetime");
            entity.Property(e => e.ApproveCcat)
                .HasColumnType("datetime")
                .HasColumnName("ApproveCCAt");
            entity.Property(e => e.ClosedAt).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CurrentState).HasMaxLength(40);
            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.ExInvoiceRef).HasMaxLength(40);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.ExclItemCost).HasColumnType("money");
            entity.Property(e => e.ExclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.ExclUnitCost).HasColumnType("money");
            entity.Property(e => e.ExclUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.InclItemCost).HasColumnType("money");
            entity.Property(e => e.InclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.InclUnitCost).HasColumnType("money");
            entity.Property(e => e.InclUnitCostSrc).HasColumnType("decimal(38, 14)");
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.InvoiceItemDescription).HasMaxLength(120);
            entity.Property(e => e.InvoiceItemQuantity).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.InvoiceMpId).HasColumnName("InvoiceMpID");
            entity.Property(e => e.InvoiceRef).HasMaxLength(40);
            entity.Property(e => e.ItemTax).HasColumnType("money");
            entity.Property(e => e.ItemTaxSrc).HasColumnType("money");
            entity.Property(e => e.ItemTaxTotal).HasColumnType("money");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.PoitemId).HasColumnName("POItemID");
            entity.Property(e => e.PostingDate).HasColumnType("date");
            entity.Property(e => e.PreApproveAt).HasColumnType("datetime");
            entity.Property(e => e.PreApproveCcat)
                .HasColumnType("datetime")
                .HasColumnName("PreApproveCCAt");
            entity.Property(e => e.ProcessorId).HasColumnName("ProcessorID");
            entity.Property(e => e.QuotePendingAt).HasColumnType("datetime");
            entity.Property(e => e.RequestItemTypeId).HasColumnName("RequestItemTypeID");
            entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitCostSrc).HasColumnType("money");
            entity.Property(e => e.UnitTax).HasColumnType("money");
            entity.Property(e => e.UnitTaxSrc).HasColumnType("money");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FactInvoiceItem>(entity =>
        {
            entity.HasKey(e => new { e.InvoiceItemId, e.DataSource });

            entity.ToTable("FactInvoiceItem", "stg");

            entity.HasIndex(e => e.CompanyId, "IX_FactInvoiceItem_CompanyID");

            entity.HasIndex(e => e.InvoiceId, "IX_FactInvoiceItem_InvoiceID");

            entity.HasIndex(e => e.InvoiceItemId, "IX_FactInvoiceItem_InvoiceItemID");

            entity.HasIndex(e => e.PoitemId, "IX_FactInvoiceItem_POItemID");

            entity.HasIndex(e => e.ProcessorId, "IX_FactInvoiceItem_ProcessorID");

            entity.HasIndex(e => e.SupplierId, "IX_FactInvoiceItem_SupplierID");

            entity.Property(e => e.InvoiceItemId).HasColumnName("InvoiceItemID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.ExInvoiceRef).HasMaxLength(40);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.ExclItemCost).HasColumnType("money");
            entity.Property(e => e.ExclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.ExclUnitCost).HasColumnType("money");
            entity.Property(e => e.ExclUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.InclItemCost).HasColumnType("money");
            entity.Property(e => e.InclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.InclUnitCost).HasColumnType("money");
            entity.Property(e => e.InclUnitCostSrc).HasColumnType("decimal(38, 14)");
            entity.Property(e => e.InvoiceDate).HasColumnType("date");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceItemDescription).HasMaxLength(120);
            entity.Property(e => e.InvoiceItemQuantity).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.InvoiceMpId).HasColumnName("InvoiceMpID");
            entity.Property(e => e.InvoiceRef).HasMaxLength(40);
            entity.Property(e => e.ItemTax).HasColumnType("money");
            entity.Property(e => e.ItemTaxSrc).HasColumnType("money");
            entity.Property(e => e.ItemTaxTotal).HasColumnType("money");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.PoitemId).HasColumnName("POItemID");
            entity.Property(e => e.PostingDate).HasColumnType("date");
            entity.Property(e => e.ProcessorId).HasColumnName("ProcessorID");
            entity.Property(e => e.RequestItemTypeId).HasColumnName("RequestItemTypeID");
            entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitCostSrc).HasColumnType("money");
            entity.Property(e => e.UnitTax).HasColumnType("money");
            entity.Property(e => e.UnitTaxSrc).HasColumnType("money");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FactPurchaseOrder>(entity =>
        {
            entity.ToTable("FactPurchaseOrder");

            entity.HasIndex(e => e.PocurrentStateId, "IX_FactPurchaseOrderCurrentStateID");

            entity.HasIndex(e => e.DimCompanyId, "IX_FactPurchaseOrder_DimCompanyID");

            entity.HasIndex(e => e.Poid, "IX_FactPurchaseOrder_POID");

            entity.HasIndex(e => e.PoitemId, "IX_FactPurchaseOrder_POItemID");

            entity.HasIndex(e => e.PurchaseDate, "IX_FactPurchaseOrder_PurchaseDate");

            entity.HasIndex(e => new { e.RequestItemId, e.DataSource }, "IX_FactPurchaseOrder_RequestItemID");

            entity.Property(e => e.FactPurchaseOrderId).HasColumnName("FactPurchaseOrderID");
            entity.Property(e => e.ClosedAt).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CurrencyCode).HasMaxLength(20);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CurrentState).HasMaxLength(40);
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DimCompanyId).HasColumnName("DimCompanyID");
            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.DimSupplierId).HasColumnName("DimSupplierID");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.ExclItemCost).HasColumnType("money");
            entity.Property(e => e.ExclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.ExclUnitCost).HasColumnType("money");
            entity.Property(e => e.ExclUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.GlaccountGroupId).HasColumnName("GLAccountGroupID");
            entity.Property(e => e.InclItemCost).HasColumnType("money");
            entity.Property(e => e.InclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.InclUnitCost).HasColumnType("money");
            entity.Property(e => e.InclUnitCostSrc).HasColumnType("decimal(38, 14)");
            entity.Property(e => e.InvoiceLocationId).HasColumnName("InvoiceLocationID");
            entity.Property(e => e.InvoicedAmount).HasColumnType("money");
            entity.Property(e => e.ItemTax).HasColumnType("money");
            entity.Property(e => e.ItemTaxSrc).HasColumnType("money");
            entity.Property(e => e.PhysicalLocationId).HasColumnName("PhysicalLocationID");
            entity.Property(e => e.Pocomments)
                .HasMaxLength(256)
                .HasColumnName("POComments");
            entity.Property(e => e.PocreationDate)
                .HasColumnType("datetime")
                .HasColumnName("POCreationDate");
            entity.Property(e => e.PocurrentStateId).HasColumnName("POCurrentStateID");
            entity.Property(e => e.PodeliveryLocationId).HasColumnName("PODeliveryLocationID");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.PoisAcknowledged).HasColumnName("POIsAcknowledged");
            entity.Property(e => e.PoisQuery).HasColumnName("POIsQuery");
            entity.Property(e => e.PoitemDescription)
                .HasMaxLength(256)
                .HasColumnName("POItemDescription");
            entity.Property(e => e.PoitemId).HasColumnName("POItemID");
            entity.Property(e => e.PopurchasedAt)
                .HasColumnType("datetime")
                .HasColumnName("POPurchasedAt");
            entity.Property(e => e.Poreference)
                .HasMaxLength(40)
                .HasColumnName("POReference");
            entity.Property(e => e.PunchoutCompleteAt).HasColumnType("datetime");
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaserId).HasColumnName("PurchaserID");
            entity.Property(e => e.ReceiptedAmount).HasColumnType("money");
            entity.Property(e => e.RequestItemId).HasColumnName("RequestItemID");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TaxRateCode).HasMaxLength(20);
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitTax).HasColumnType("money");
            entity.Property(e => e.UnitTaxSrc).HasColumnType("money");
        });

        modelBuilder.Entity<FactPurchaseOrder1>(entity =>
        {
            entity.HasKey(e => new { e.PoitemId, e.DataSource });

            entity.ToTable("FactPurchaseOrder", "stg");

            entity.Property(e => e.PoitemId).HasColumnName("POItemID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClosedAt).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CurrencyCode).HasMaxLength(20);
            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CurrentState).HasMaxLength(40);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.ExclItemCost).HasColumnType("money");
            entity.Property(e => e.ExclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.ExclUnitCost).HasColumnType("money");
            entity.Property(e => e.ExclUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.InclItemCost).HasColumnType("money");
            entity.Property(e => e.InclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.InclUnitCost).HasColumnType("money");
            entity.Property(e => e.InclUnitCostSrc).HasColumnType("decimal(38, 14)");
            entity.Property(e => e.InvoiceLocationId).HasColumnName("InvoiceLocationID");
            entity.Property(e => e.ItemTax).HasColumnType("money");
            entity.Property(e => e.ItemTaxSrc).HasColumnType("money");
            entity.Property(e => e.PhysicalLocationId).HasColumnName("PhysicalLocationID");
            entity.Property(e => e.Pocomments)
                .HasMaxLength(256)
                .HasColumnName("POComments");
            entity.Property(e => e.PocreationDate)
                .HasColumnType("datetime")
                .HasColumnName("POCreationDate");
            entity.Property(e => e.PocurrentStateId).HasColumnName("POCurrentStateID");
            entity.Property(e => e.PodeliveryLocationId).HasColumnName("PODeliveryLocationID");
            entity.Property(e => e.Poid).HasColumnName("POID");
            entity.Property(e => e.PoisAcknowledged).HasColumnName("POIsAcknowledged");
            entity.Property(e => e.PoisQuery).HasColumnName("POIsQuery");
            entity.Property(e => e.PoitemDescription)
                .HasMaxLength(256)
                .HasColumnName("POItemDescription");
            entity.Property(e => e.PopurchasedAt)
                .HasColumnType("datetime")
                .HasColumnName("POPurchasedAt");
            entity.Property(e => e.Poreference)
                .HasMaxLength(40)
                .HasColumnName("POReference");
            entity.Property(e => e.PunchoutCompleteAt).HasColumnType("datetime");
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaserId).HasColumnName("PurchaserID");
            entity.Property(e => e.RequestItemId).HasColumnName("RequestItemID");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TaxRateCode).HasMaxLength(20);
            entity.Property(e => e.TaxRateId).HasColumnName("TaxRateID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitTax).HasColumnType("money");
            entity.Property(e => e.UnitTaxSrc).HasColumnType("money");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FactReceipt>(entity =>
        {
            entity.ToTable("FactReceipt");

            entity.Property(e => e.FactReceiptId).HasColumnName("FactReceiptID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateReceived).HasColumnType("date");
            entity.Property(e => e.DeliveryNoteNumber).HasMaxLength(1024);
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.PoitemId).HasColumnName("POItemID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");
            entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitCostSrc).HasColumnType("money");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FactReceipt1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FactReceipt", "stg");

            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateReceived).HasColumnType("date");
            entity.Property(e => e.DeliveryNoteNumber).HasMaxLength(1024);
            entity.Property(e => e.PoitemId).HasColumnName("POItemID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");
            entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitCostSrc).HasColumnType("money");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FactRequest>(entity =>
        {
            entity.ToTable("FactRequest");

            entity.HasIndex(e => e.ApprovalId, "IX_FactRequestApprovalID");

            entity.HasIndex(e => e.RequestCurrentStateId, "IX_FactRequestCurrentStateID");

            entity.HasIndex(e => new { e.RequestRequestorId, e.CurrentState }, "IX_FactRequest_ApprovalTime");

            entity.HasIndex(e => new { e.RequestRequestorId, e.ApproveCompleteAt }, "IX_FactRequest_ApproveComplete");

            entity.HasIndex(e => e.DataSource, "IX_FactRequest_DataSource");

            entity.HasIndex(e => e.DimCompanyId, "IX_FactRequest_DimCompanyID");

            entity.HasIndex(e => e.DimEmployeeId, "IX_FactRequest_DimEmployeeID");

            entity.HasIndex(e => e.DimSupplierId, "IX_FactRequest_DimSupplierID");

            entity.HasIndex(e => e.GlaccountGroupId, "IX_FactRequest_GLAccountGroupID");

            entity.HasIndex(e => new { e.RequestId, e.DataSource }, "IX_FactRequest_RequestID");

            entity.HasIndex(e => e.RequestItemDateStamp, "IX_FactRequest_RequestItemDateStamp");

            entity.HasIndex(e => new { e.RequestItemId, e.DataSource }, "IX_FactRequest_RequestItemID");

            entity.HasIndex(e => new { e.RequestRequestorId, e.CurrentState }, "IX_FactRequest_RequestRequestorID");

            entity.HasIndex(e => new { e.TenantId, e.DataSource }, "IX_FactRequest_TenantID_Datasource");

            entity.Property(e => e.FactRequestId).HasColumnName("FactRequestID");
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.ApproveCompleteAt).HasColumnType("datetime");
            entity.Property(e => e.ApproveCompleteCcat)
                .HasColumnType("datetime")
                .HasColumnName("ApproveCompleteCCAt");
            entity.Property(e => e.ApproveSubmitAt).HasColumnType("datetime");
            entity.Property(e => e.ApproveSubmitCcat)
                .HasColumnType("datetime")
                .HasColumnName("ApproveSubmitCCAt");
            entity.Property(e => e.AutoApproveAt).HasColumnType("datetime");
            entity.Property(e => e.CanceledAt).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CurrentState).HasMaxLength(40);
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DimApprovalId).HasColumnName("DimApprovalID");
            entity.Property(e => e.DimCompanyId).HasColumnName("DimCompanyID");
            entity.Property(e => e.DimCurrencyId).HasColumnName("DimCurrencyID");
            entity.Property(e => e.DimEmployeeId).HasColumnName("DimEmployeeID");
            entity.Property(e => e.DimSupplierId).HasColumnName("DimSupplierID");
            entity.Property(e => e.ExclItemCost).HasColumnType("money");
            entity.Property(e => e.ExclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.ExclUnitCost).HasColumnType("money");
            entity.Property(e => e.ExclUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.GlaccountGroupId).HasColumnName("GLAccountGroupID");
            entity.Property(e => e.InclItemCost).HasColumnType("money");
            entity.Property(e => e.InclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.InclUnitCost).HasColumnType("money");
            entity.Property(e => e.InclUnitCostSrc).HasColumnType("decimal(38, 14)");
            entity.Property(e => e.ItemTax).HasColumnType("money");
            entity.Property(e => e.ItemTaxSrc).HasColumnType("money");
            entity.Property(e => e.PreApproveAt).HasColumnType("datetime");
            entity.Property(e => e.PreApproveCcat)
                .HasColumnType("datetime")
                .HasColumnName("PreApproveCCAt");
            entity.Property(e => e.QuotePendingAt).HasColumnType("datetime");
            entity.Property(e => e.RejectedAt).HasColumnType("datetime");
            entity.Property(e => e.RequestAssistantId).HasColumnName("RequestAssistantID");
            entity.Property(e => e.RequestCurrentStateId).HasColumnName("RequestCurrentStateID");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.RequestItemApprovalId).HasColumnName("RequestItemApprovalID");
            entity.Property(e => e.RequestItemCurrencyId).HasColumnName("RequestItemCurrencyID");
            entity.Property(e => e.RequestItemDateStamp).HasColumnType("date");
            entity.Property(e => e.RequestItemDeliveryLocationId).HasColumnName("RequestItemDeliveryLocationID");
            entity.Property(e => e.RequestItemDescription).HasMaxLength(120);
            entity.Property(e => e.RequestItemExchangeRate).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.RequestItemId).HasColumnName("RequestItemID");
            entity.Property(e => e.RequestItemQuantity).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.RequestItemRequestorId).HasColumnName("RequestItemRequestorID");
            entity.Property(e => e.RequestItemServiceSupplierId).HasColumnName("RequestItemServiceSupplierID");
            entity.Property(e => e.RequestItemSupplierId).HasColumnName("RequestItemSupplierID");
            entity.Property(e => e.RequestItemTaxAmount).HasColumnType("money");
            entity.Property(e => e.RequestItemTaxRateId).HasColumnName("RequestItemTaxRateID");
            entity.Property(e => e.RequestItemTypeBaseResourceName).HasMaxLength(40);
            entity.Property(e => e.RequestItemTypeId).HasColumnName("RequestItemTypeID");
            entity.Property(e => e.RequestItemUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.RequestRequestorId).HasColumnName("RequestRequestorID");
            entity.Property(e => e.RequestTitle).HasMaxLength(256);
            entity.Property(e => e.RequestTypeBaseResourceName).HasMaxLength(40);
            entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitTax).HasColumnType("money");
            entity.Property(e => e.UnitTaxSrc).HasColumnType("money");
        });

        modelBuilder.Entity<FactRequest1>(entity =>
        {
            entity.HasKey(e => new { e.RequestId, e.DataSource });

            entity.ToTable("FactRequest", "stg");

            entity.HasIndex(e => e.RequestId, "IX_FactRequest_RequestID");

            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ApproveCompleteAt).HasColumnType("datetime");
            entity.Property(e => e.ApproveCompleteCcat)
                .HasColumnType("datetime")
                .HasColumnName("ApproveCompleteCCAt");
            entity.Property(e => e.ApproveSubmitAt).HasColumnType("datetime");
            entity.Property(e => e.ApproveSubmitCcat)
                .HasColumnType("datetime")
                .HasColumnName("ApproveSubmitCCAt");
            entity.Property(e => e.AssistantId).HasColumnName("AssistantID");
            entity.Property(e => e.AutoApproveAt).HasColumnType("datetime");
            entity.Property(e => e.CanceledAt).HasColumnType("datetime");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CurrentState).HasMaxLength(40);
            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.PreApproveAt).HasColumnType("datetime");
            entity.Property(e => e.PreApproveCcat)
                .HasColumnType("datetime")
                .HasColumnName("PreApproveCCAt");
            entity.Property(e => e.QuotePendingAt).HasColumnType("datetime");
            entity.Property(e => e.RejectedAt).HasColumnType("datetime");
            entity.Property(e => e.RequestTypeBaseResourceName).HasMaxLength(40);
            entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            entity.Property(e => e.RequestorId).HasColumnName("RequestorID");
            entity.Property(e => e.Title).HasMaxLength(256);
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FactRequestItem>(entity =>
        {
            entity.HasKey(e => new { e.RequestItemId, e.DataSource });

            entity.ToTable("FactRequestItem", "stg");

            entity.HasIndex(e => e.RequestItemId, "IX_FactRequestItem_RequestItemID");

            entity.Property(e => e.RequestItemId).HasColumnName("RequestItemID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.ExclItemCost).HasColumnType("money");
            entity.Property(e => e.ExclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.ExclUnitCost).HasColumnType("money");
            entity.Property(e => e.ExclUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.InclItemCost).HasColumnType("money");
            entity.Property(e => e.InclItemCostSrc).HasColumnType("money");
            entity.Property(e => e.InclUnitCost).HasColumnType("money");
            entity.Property(e => e.InclUnitCostSrc).HasColumnType("decimal(38, 14)");
            entity.Property(e => e.ItemTax).HasColumnType("money");
            entity.Property(e => e.ItemTaxSrc).HasColumnType("money");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.RequestItemApprovalId).HasColumnName("RequestItemApprovalID");
            entity.Property(e => e.RequestItemCurrencyId).HasColumnName("RequestItemCurrencyID");
            entity.Property(e => e.RequestItemDateStamp).HasColumnType("date");
            entity.Property(e => e.RequestItemDeliveryLocationId).HasColumnName("RequestItemDeliveryLocationID");
            entity.Property(e => e.RequestItemDescription).HasMaxLength(120);
            entity.Property(e => e.RequestItemExchangeRate).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.RequestItemQuantity).HasColumnType("decimal(18, 9)");
            entity.Property(e => e.RequestItemRequestorId).HasColumnName("RequestItemRequestorID");
            entity.Property(e => e.RequestItemServiceSupplierId).HasColumnName("RequestItemServiceSupplierID");
            entity.Property(e => e.RequestItemSupplierId).HasColumnName("RequestItemSupplierID");
            entity.Property(e => e.RequestItemTaxAmount).HasColumnType("money");
            entity.Property(e => e.RequestItemTaxRateId).HasColumnName("RequestItemTaxRateID");
            entity.Property(e => e.RequestItemTypeBaseResourceName).HasMaxLength(40);
            entity.Property(e => e.RequestItemTypeId).HasColumnName("RequestItemTypeID");
            entity.Property(e => e.RequestItemUnitCostSrc).HasColumnType("money");
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.UnitTax).HasColumnType("money");
            entity.Property(e => e.UnitTaxSrc).HasColumnType("money");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FactRequestStateHistory>(entity =>
        {
            entity.HasKey(e => e.FactRequestStateHistoryId).HasName("PK__FactRequ__7959AFBEC04572AC");

            entity.ToTable("FactRequestStateHistory");

            entity.Property(e => e.FactRequestStateHistoryId).HasColumnName("FactRequestStateHistoryID");
            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.DataSource).HasMaxLength(256);
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.ResourceName).HasMaxLength(40);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
            entity.Property(e => e.Watermark).HasColumnType("datetime");
        });

        modelBuilder.Entity<FinancialPeriodDate>(entity =>
        {
            entity.HasKey(e => new { e.DimFinancialPeriodId, e.TheDate });

            entity.ToTable("FinancialPeriodDate");

            entity.Property(e => e.DimFinancialPeriodId).HasColumnName("DimFinancialPeriodID");
            entity.Property(e => e.TheDate).HasColumnType("date");
        });

        modelBuilder.Entity<InvoiceExtractionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InvoiceE__3213E83FF5A67856");

            entity.ToTable("InvoiceExtractionLog", "log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CorrelationId).HasColumnName("correlationId");
            entity.Property(e => e.DateSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("dateSubmitted");
            entity.Property(e => e.EmailFrom)
                .HasMaxLength(255)
                .HasColumnName("emailFrom");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(255)
                .HasColumnName("errorMessage");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(255)
                .HasColumnName("invoiceNumber");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<MonthlyRequestToPurchasePercentileBenchmark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MonthlyRequestToPurchasePercentileBenchmark", "benchmark");

            entity.Property(e => e.Percentile).HasColumnName("percentile");
            entity.Property(e => e.PercentileFormatted)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("YYYYMM");
        });

        modelBuilder.Entity<PopulationRequestTurnaroundPercentile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PopulationRequestTurnaroundPercentile", "benchmark");

            entity.Property(e => e.Percentile).HasColumnName("percentile");
            entity.Property(e => e.Turnaround).HasColumnName("turnaround");
        });

        modelBuilder.Entity<RequestStateHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RequestStateHistory", "stg");

            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.ResourceName).HasMaxLength(40);
            entity.Property(e => e.TenantId).HasColumnName("TenantID");
        });

        modelBuilder.Entity<RequestToPurchasePercentileBenchmark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RequestToPurchasePercentileBenchmark", "benchmark");

            entity.Property(e => e.PercentileFormatted)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Role", "stg");

            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResourceName).HasMaxLength(40);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("source");

            entity.Property(e => e.ApprovalId).HasColumnName("ApprovalID");
            entity.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(51)
                .IsUnicode(false);
            entity.Property(e => e.DateStamp).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.Info).HasMaxLength(256);
            entity.Property(e => e.Note).HasMaxLength(256);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.UserAction).HasMaxLength(40);
        });

        modelBuilder.Entity<StoredProcedure>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StoredProcedure", "stg");

            entity.Property(e => e.StoredProcedureName).HasMaxLength(128);
        });

        modelBuilder.Entity<TenantMonthlyRequestToPurchasePercentileBenchmark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TenantMonthlyRequestToPurchasePercentileBenchmark", "benchmark");

            entity.Property(e => e.Fxtenantid).HasColumnName("fxtenantid");
            entity.Property(e => e.PercentileFormatted)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Turnaround).HasColumnName("turnaround");
            entity.Property(e => e.Yyyymm)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("YYYYMM");
        });

        modelBuilder.Entity<TenantOutlier>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TenantOutlier", "benchmark");

            entity.Property(e => e.Fxtenantid).HasColumnName("fxtenantid");
        });

        modelBuilder.Entity<TenantRequestToPurchasePercentileBenchmark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TenantRequestToPurchasePercentileBenchmark", "benchmark");

            entity.Property(e => e.Fxtenantid).HasColumnName("fxtenantid");
            entity.Property(e => e.PercentileFormatted)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Turnaround).HasColumnName("turnaround");
        });

        modelBuilder.Entity<TenantRequestTurnaroundPercentile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TenantRequestTurnaroundPercentile", "benchmark");

            entity.Property(e => e.Fxtenantid).HasColumnName("fxtenantid");
            entity.Property(e => e.Percentile).HasColumnName("percentile");
            entity.Property(e => e.Turnaround).HasColumnName("turnaround");
        });

        modelBuilder.Entity<TenantUrl>(entity =>
        {
            entity.HasKey(e => new { e.WebsiteUrl, e.FxTenantId, e.DataSource });

            entity.ToTable("TenantURL", "stg");

            entity.Property(e => e.WebsiteUrl)
                .HasMaxLength(256)
                .HasColumnName("WebsiteURL");
            entity.Property(e => e.FxTenantId).HasColumnName("FxTenantID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WebsiteDatasourceConcat).HasMaxLength(513);
            entity.Property(e => e.WebsiteInitialCatalog).HasMaxLength(256);
            entity.Property(e => e.WebsiteSourceServer).HasMaxLength(256);
        });

        modelBuilder.Entity<Watermark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Watermark", "stg", tb => tb.HasComment("Holds watermark values for incremental loading"));

            entity.Property(e => e.SinkDatabase)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SinkServer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SinkTableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SourceDatabase)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SourceServer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SourceTableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WatermarkColumn)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WatermarkValue).HasColumnType("datetime");
        });

        modelBuilder.Entity<WatermarkSptoSp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WatermarkSPToSP", "stg");

            entity.Property(e => e.SinkDatabase)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SinkProcedure)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SinkSchema)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SinkServer)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SourceDatabase)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SourceProcedure)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SourceSchema)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SourceServer)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.WatermarkColumn)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.WatermarkValue).HasColumnType("datetime");
        });

        modelBuilder.Entity<WatermarkTableToSp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WatermarkTableToSP", "stg");

            entity.Property(e => e.SinkDatabase)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SinkProcedure)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SinkSchema)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SinkServer)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SourceDatabase)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SourceSchema)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SourceServer)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.SourceTable)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.TableTypeName)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.TableTypeParameterName)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.WatermarkColumn)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.WatermarkValue).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
