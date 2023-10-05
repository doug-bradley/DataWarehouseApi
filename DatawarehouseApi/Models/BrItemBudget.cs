using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class BrItemBudget
{
    public long? RequestItemId { get; set; }

    public long? InvoiceItemId { get; set; }

    public long? GlaccountId { get; set; }

    public long? GlsegmentId { get; set; }

    public string? DataSource { get; set; }
}
