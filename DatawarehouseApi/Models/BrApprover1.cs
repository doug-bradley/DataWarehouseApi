using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class BrApprover1
{
    public long ApproverId { get; set; }

    public long TenantId { get; set; }

    public long ApprovalId { get; set; }

    public long EmployeeId { get; set; }

    public string DataSource { get; set; } = null!;
}
