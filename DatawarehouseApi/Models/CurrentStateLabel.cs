using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class CurrentStateLabel
{
    public string CurrentStateId { get; set; } = null!;

    public string? ResourceName { get; set; }

    public string? Label { get; set; }
}
