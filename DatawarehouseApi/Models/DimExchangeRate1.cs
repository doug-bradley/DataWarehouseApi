using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimExchangeRate1
{
    public long ExchangeRateId { get; set; }

    public long TenantId { get; set; }

    public long? CurrencyId { get; set; }

    public string? Type { get; set; }

    public decimal? Value { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsActive { get; set; }

    public long? DestinationCurrencyId { get; set; }

    public string DataSource { get; set; } = null!;
}
