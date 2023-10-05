using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class Role
{
    public long? RoleId { get; set; }

    public string? ResourceName { get; set; }

    public string? DataSource { get; set; }
}
