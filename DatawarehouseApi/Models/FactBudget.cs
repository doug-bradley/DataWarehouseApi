using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactBudget
{
    public long FactBudgetId { get; set; }

    public long DimFinancialPeriodId { get; set; }

    public long DimGlaccountId { get; set; }

    public long? BudgetId { get; set; }

    public long? TenantId { get; set; }

    public long? GlaccountId { get; set; }

    public long? GlsegmentId { get; set; }

    public long? FinancialPeriodId { get; set; }

    public decimal? Value { get; set; }

    public decimal? ActualSpend { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }
}
