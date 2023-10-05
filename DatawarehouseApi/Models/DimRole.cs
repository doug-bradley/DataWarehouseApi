using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimRole
{
    public long DimRoleId { get; set; }

    public long? RoleId { get; set; }

    public string? ResourceName { get; set; }

    public string? DataSource { get; set; }
}
