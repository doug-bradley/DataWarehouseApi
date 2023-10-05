using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimGlaccount
{
    public long DimGlaccountId { get; set; }

    public long? DimCompanyId { get; set; }

    public long? GlaccountId { get; set; }

    public string? Glcode { get; set; }

    public string? Name { get; set; }

    public string? FullName { get; set; }

    public long? GlcodeMaskId { get; set; }

    public long? TenantId { get; set; }

    public long? CompanyId { get; set; }

    public bool? IsActive { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }
}
