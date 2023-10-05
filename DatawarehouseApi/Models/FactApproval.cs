using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactApproval
{
    public long FactApprovalId { get; set; }

    public long? DimEmployeeId { get; set; }

    public long? RequestId { get; set; }

    public long? InvoiceId { get; set; }

    public string? Approval { get; set; }

    public int? ApprovalOrder { get; set; }

    public long? EmployeeId { get; set; }

    public string? Employee { get; set; }

    public DateTime? DateStamp { get; set; }

    public string? UserAction { get; set; }

    public string? DataSource { get; set; }
}
