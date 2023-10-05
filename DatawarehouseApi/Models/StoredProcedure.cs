using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class StoredProcedure
{
    public string StoredProcedureName { get; set; } = null!;

    public int ExecutionOrder { get; set; }

    public bool IsActive { get; set; }
}
