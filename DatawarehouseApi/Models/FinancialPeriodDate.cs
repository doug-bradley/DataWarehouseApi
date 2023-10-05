using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FinancialPeriodDate
{
    public long DimFinancialPeriodId { get; set; }

    public DateTime TheDate { get; set; }
}
