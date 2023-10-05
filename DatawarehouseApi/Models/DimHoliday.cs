using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimHoliday
{
    public DateTime TheDate { get; set; }

    public string HolidayText { get; set; } = null!;
}
