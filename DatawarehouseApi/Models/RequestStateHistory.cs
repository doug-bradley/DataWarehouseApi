using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class RequestStateHistory
{
    public long? RequestId { get; set; }

    public long? CurrentStateId { get; set; }

    public string? ResourceName { get; set; }

    public int? MinutesSpentInState { get; set; }

    public long? TenantId { get; set; }

    public Guid? FxTenantId { get; set; }
}
