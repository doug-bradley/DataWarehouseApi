using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class BrGlaccountGroup
{
    public long GroupId { get; set; }

    public long DimGlaccountId { get; set; }

    public long? RequestItemId { get; set; }

    public long? InvoiceItemId { get; set; }

    public string? DataSource { get; set; }
}
