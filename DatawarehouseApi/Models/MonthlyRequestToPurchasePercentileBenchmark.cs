using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class MonthlyRequestToPurchasePercentileBenchmark
{
    public int? Percentile { get; set; }

    public string? Yyyymm { get; set; }

    public string? PercentileFormatted { get; set; }

    public int? Turnaround { get; set; }
}
