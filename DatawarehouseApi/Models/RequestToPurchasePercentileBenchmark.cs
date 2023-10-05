using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class RequestToPurchasePercentileBenchmark
{
    public int? Turnaround { get; set; }

    public int? Percentile { get; set; }

    public string? PercentileFormatted { get; set; }
}
