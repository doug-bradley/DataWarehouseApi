using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class TenantMonthlyRequestToPurchasePercentileBenchmark
{
    public Guid? Fxtenantid { get; set; }

    public string? Yyyymm { get; set; }

    public int? Turnaround { get; set; }

    public double? Percentile { get; set; }

    public string? PercentileFormatted { get; set; }
}
