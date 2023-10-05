using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimCompany
{
    public long DimCompanyId { get; set; }

    public long? DimCurrencyId { get; set; }

    public long TenantId { get; set; }

    public string TenantCode { get; set; } = null!;

    public string TenantName { get; set; } = null!;

    public string TenantLoginName { get; set; } = null!;

    public string TenantEmail { get; set; } = null!;

    public DateTime TenantCreationDate { get; set; }

    public DateTime? TenantCancelledDate { get; set; }

    public string? TenantShortName { get; set; }

    public Guid FxTenantId { get; set; }

    public Guid? AadtenantId { get; set; }

    public long? CompanyId { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyRegistrationNumber { get; set; }

    public string? CompanyTaxRegistrationNumber { get; set; }

    public long? CompanyCurrencyId { get; set; }

    public string? CompanyTerms { get; set; }

    public string? WebsiteUrl { get; set; }

    public string? DataSource { get; set; }

    public long? DimReportingCurrencyId { get; set; }

    public long? ReportingCurrencyId { get; set; }
}
