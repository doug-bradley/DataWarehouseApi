using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimCurrency
{
    public long DimCurrencyId { get; set; }

    public long? CurrencyId { get; set; }

    public long? TenantId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }
}
