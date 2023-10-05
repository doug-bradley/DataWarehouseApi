using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class ApimLog
{
    public string? ApiId { get; set; }

    public string? ApiRevision { get; set; }

    public string? ApimSubscriptionId { get; set; }

    public string? BackendRequestHeaders { get; set; }

    public int? BackendTime { get; set; }

    public bool? IsRequestSuccess { get; set; }

    public string? OperationId { get; set; }

    public string? ProductId { get; set; }

    public int? RequestSize { get; set; }

    public int? ResponseCode { get; set; }

    public int? ResponseSize { get; set; }

    public DateTime? TimeGenerated { get; set; }

    public int? TotalTime { get; set; }

    public string? Url { get; set; }

    public string? UserId { get; set; }

    public int? ClientTime { get; set; }
}
