using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class BrEmployeeRole
{
    public long? DimEmployeeId { get; set; }

    public long? DimRoleId { get; set; }

    public long? EmployeeId { get; set; }

    public long? RoleId { get; set; }

    public string? DataSource { get; set; }
}
