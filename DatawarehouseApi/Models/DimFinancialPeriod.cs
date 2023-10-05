using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimFinancialPeriod
{
    public long DimFinancialPeriodId { get; set; }

    public long? FinancialPeriodId { get; set; }

    public long? TenantId { get; set; }

    public long? FinancialYearId { get; set; }

    public string? Description { get; set; }

    public short? PeriodNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? FinancialYearDescription { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }
}
