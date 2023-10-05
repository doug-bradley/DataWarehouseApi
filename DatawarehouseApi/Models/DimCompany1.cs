using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimCompany1
{
    public long TenantId { get; set; }

    public string? TenantCode { get; set; }

    public string? TenantName { get; set; }

    public string? TenantLoginName { get; set; }

    public string? TenantEmail { get; set; }

    public DateTime? TenantCreationDate { get; set; }

    public DateTime? TenantCancelledDate { get; set; }

    public bool? TenantIsActive { get; set; }

    public string? TenantShortName { get; set; }

    public Guid? FxTenantId { get; set; }

    public Guid? AadtenantId { get; set; }

    public long? ReportingCurrencyId { get; set; }

    public long CompanyId { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyRegistrationNumber { get; set; }

    public string? CompanyTaxRegistrationNumber { get; set; }

    public string? CompanyPoreferenceMask { get; set; }

    public long? CompanyCurrencyId { get; set; }

    public bool? CompanyIsActive { get; set; }

    public string? CompanyTerms { get; set; }

    public string DataSource { get; set; } = null!;
}
