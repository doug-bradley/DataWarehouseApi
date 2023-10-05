using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimEmployee
{
    public long DimEmployeeId { get; set; }

    public long? EmployeeId { get; set; }

    public long? TenantId { get; set; }

    public Guid? FxUserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmployeeRef { get; set; }

    public string? Email { get; set; }

    public bool? IsAway { get; set; }

    public string? TimeZoneId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? AaduserId { get; set; }

    public string? LdapuserId { get; set; }

    public long? LocationId { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }

    public long? DefaultCompanyId { get; set; }

    public long? DefaultInvoiceLocationId { get; set; }

    public long? DefaultPhysicalLocationId { get; set; }
}
