using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class Configuration
{
    public string? ExtServerName { get; set; }

    public string? ExtDatabaseName { get; set; }
}
