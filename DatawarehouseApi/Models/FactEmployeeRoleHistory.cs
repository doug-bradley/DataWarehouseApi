using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactEmployeeRoleHistory
{
    public long FactEmployeeRoleHistoryId { get; set; }

    public long? DimEmployeeId { get; set; }

    public long? DimRoleId { get; set; }

    public long? EmployeeHistoryId { get; set; }

    public long? EmployeeId { get; set; }

    public long? CurrentUserId { get; set; }

    public DateTime? DateStamp { get; set; }

    public string? DataSource { get; set; }
}
