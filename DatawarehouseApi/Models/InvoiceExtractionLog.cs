using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class InvoiceExtractionLog
{
    public int Id { get; set; }

    public string? EmailFrom { get; set; }

    public long? UserId { get; set; }

    public Guid? CorrelationId { get; set; }

    public DateTime? DateSubmitted { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? ErrorMessage { get; set; }

    public string? Status { get; set; }

    public Guid? TenantId { get; set; }
}
