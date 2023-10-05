using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class BrApprover
{
    public long DimEmployeeId { get; set; }

    public long DimApprovalId { get; set; }

    public long ApproverId { get; set; }

    public long TenantId { get; set; }

    public long ApprovalId { get; set; }

    public long EmployeeId { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }

    public long? RequestTypeId { get; set; }
}
