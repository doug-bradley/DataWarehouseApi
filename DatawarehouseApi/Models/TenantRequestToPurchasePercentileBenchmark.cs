using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class TenantRequestToPurchasePercentileBenchmark
{
    public Guid? Fxtenantid { get; set; }

    public int? Turnaround { get; set; }

    public double? Percentile { get; set; }

    public string? PercentileFormatted { get; set; }
}
