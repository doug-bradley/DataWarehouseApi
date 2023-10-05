using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

/// <summary>
/// Holds watermark values for incremental loading
/// </summary>
public partial class Watermark
{
    public string? SourceServer { get; set; }

    public string? SourceDatabase { get; set; }

    public string SourceTableName { get; set; } = null!;

    public string? SinkServer { get; set; }

    public string? SinkDatabase { get; set; }

    public string SinkTableName { get; set; } = null!;

    public DateTime WatermarkValue { get; set; }

    public string? WatermarkColumn { get; set; }

    public bool IsActive { get; set; }
}
