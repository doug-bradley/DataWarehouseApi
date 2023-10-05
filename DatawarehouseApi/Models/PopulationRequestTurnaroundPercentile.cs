using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class PopulationRequestTurnaroundPercentile
{
    public double? Turnaround { get; set; }

    public int? Percentile { get; set; }
}
