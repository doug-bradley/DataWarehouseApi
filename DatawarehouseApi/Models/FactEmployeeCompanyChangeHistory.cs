using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactEmployeeCompanyChangeHistory
{
    public long FactEmployeeCompanyChangeHistoryId { get; set; }

    public long? DimEmployeeId { get; set; }

    public long? DimCompanyId { get; set; }

    public long? EmployeeId { get; set; }

    public DateTime? DateTimeStamp { get; set; }

    public DateTime? DateStamp { get; set; }

    public long? CompanyId { get; set; }

    public string Action { get; set; } = null!;

    public Guid? FxTenantId { get; set; }

    public string? DataSource { get; set; }
}
