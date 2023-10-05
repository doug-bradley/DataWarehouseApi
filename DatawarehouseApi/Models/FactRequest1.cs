using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactRequest1
{
    public long RequestId { get; set; }

    public long? RequestTypeId { get; set; }

    public long? CurrentStateId { get; set; }

    public long? ReferenceNumber { get; set; }

    public string? Title { get; set; }

    public long? RequestorId { get; set; }

    public long? AssistantId { get; set; }

    public long? CompanyId { get; set; }

    public string? RequestTypeBaseResourceName { get; set; }

    public bool? RequestTypeBaseIsActive { get; set; }

    public string? CurrentState { get; set; }

    public DateTime? PreApproveAt { get; set; }

    public DateTime? PreApproveCcat { get; set; }

    public DateTime? ApproveSubmitAt { get; set; }

    public DateTime? ApproveCompleteAt { get; set; }

    public DateTime? ApproveSubmitCcat { get; set; }

    public DateTime? ApproveCompleteCcat { get; set; }

    public DateTime? AutoApproveAt { get; set; }

    public DateTime? QuotePendingAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? RejectedAt { get; set; }

    public DateTime? CanceledAt { get; set; }

    public DateTime? Watermark { get; set; }

    public string DataSource { get; set; } = null!;
}
