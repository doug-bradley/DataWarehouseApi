using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class AvgRequestTurnaroundByTenant
{
    public Guid? Fxtenantid { get; set; }

    public double? AvgTurnaround { get; set; }
}
