using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactApprovalHistory
{
    public long FactApprovalHistoryId { get; set; }

    public long? RequestId { get; set; }

    public long? ApprovalId { get; set; }

    public long? EmployeeId { get; set; }

    public long? CurrentStateId { get; set; }

    public DateTime? DateStamp { get; set; }

    public string? UserAction { get; set; }

    public string? Info { get; set; }

    public string? Note { get; set; }

    public long? ApprovalOrder { get; set; }

    public int? MinutesBetween { get; set; }

    public Guid? FxTenantId { get; set; }

    public string? DataSource { get; set; }
}
