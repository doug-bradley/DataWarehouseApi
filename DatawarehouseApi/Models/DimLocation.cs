using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimLocation
{
    public long DimLocationId { get; set; }

    public long LocationId { get; set; }

    public long TenantId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? Locality { get; set; }

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Coordinates { get; set; }

    public string? Contact { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string? Email { get; set; }

    public bool IsActive { get; set; }

    public long? TaxRateId { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }
}
