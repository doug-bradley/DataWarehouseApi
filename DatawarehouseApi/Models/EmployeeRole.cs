using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class EmployeeRole
{
    public long? EmployeeId { get; set; }

    public long? RoleId { get; set; }

    public string? DataSource { get; set; }
}
