using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class BrEmployeeApproval
{
    public long? ApproverId { get; set; }

    public long? TenantId { get; set; }

    public long? ApprovalId { get; set; }

    public long? EmployeeId { get; set; }

    public int? RequestTypeId { get; set; }

    public int? ThresholdValue { get; set; }

    public Guid? FxTenantId { get; set; }

    public string? DataSource { get; set; }

    public int? ApprovalOrder { get; set; }

    public bool? CanEditCore { get; set; }

    public bool? CanEditBudget { get; set; }

    public bool? CanEditCustom { get; set; }

    public bool? IsSelfApproval { get; set; }

    public bool? IsAboveThreshold { get; set; }

    public bool? IsOnBudget { get; set; }

    public bool? IsOnVariance { get; set; }

    public string? TypeName { get; set; }
}
