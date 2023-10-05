using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactEmployeeRoleHistory1
{
    public long? EmployeeHistoryId { get; set; }

    public long? EmployeeId { get; set; }

    public long? CurrentUserId { get; set; }

    public string? UserAction { get; set; }

    public DateTime? DateStamp { get; set; }

    public string? Value { get; set; }

    public string? DataSource { get; set; }
}
