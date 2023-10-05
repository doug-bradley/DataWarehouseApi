using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class TenantRequestTurnaroundPercentile
{
    public Guid Fxtenantid { get; set; }

    public double? Turnaround { get; set; }

    public int? Percentile { get; set; }
}
