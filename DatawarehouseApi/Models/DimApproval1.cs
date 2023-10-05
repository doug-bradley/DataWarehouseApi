using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimApproval1
{
    public long ApprovalId { get; set; }

    public long TenantId { get; set; }

    public string? Name { get; set; }

    public bool IsActive { get; set; }

    public bool IsRequest { get; set; }

    public bool IsInvoice { get; set; }

    public bool IsSupplier { get; set; }

    public string DataSource { get; set; } = null!;
}
