using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactBudget1
{
    public long BudgetId { get; set; }

    public long TenantId { get; set; }

    public long? GlaccountId { get; set; }

    public long? GlsegmentId { get; set; }

    public long? FinancialPeriodId { get; set; }

    public decimal? Value { get; set; }

    public decimal? ActualSpend { get; set; }

    public DateTime? Watermark { get; set; }

    public string DataSource { get; set; } = null!;
}
