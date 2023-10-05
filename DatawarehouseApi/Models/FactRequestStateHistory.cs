using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactRequestStateHistory
{
    public long FactRequestStateHistoryId { get; set; }

    public long? RequestId { get; set; }

    public long? CurrentStateId { get; set; }

    public string? ResourceName { get; set; }

    public int? MinutesSpentInState { get; set; }

    public long? TenantId { get; set; }

    public Guid? FxTenantId { get; set; }

    public DateTime? Watermark { get; set; }

    public string? DataSource { get; set; }
}
