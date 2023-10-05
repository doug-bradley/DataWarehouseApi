using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class WatermarkTableToSp
{
    public string? SourceServer { get; set; }

    public string? SourceDatabase { get; set; }

    public string? SourceSchema { get; set; }

    public string SourceTable { get; set; } = null!;

    public string? SinkServer { get; set; }

    public string? SinkDatabase { get; set; }

    public string? SinkSchema { get; set; }

    public string SinkProcedure { get; set; } = null!;

    public string? TableTypeName { get; set; }

    public string? TableTypeParameterName { get; set; }

    public DateTime WatermarkValue { get; set; }

    public string? WatermarkColumn { get; set; }

    public bool IsActive { get; set; }
}
