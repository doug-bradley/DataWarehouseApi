using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class ApextractionStatistic
{
    public Guid? TenantId { get; set; }

    public long? InvoiceId { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? LoggingType { get; set; }

    public int? Count { get; set; }

    public string? Exception { get; set; }

    public string? Properties { get; set; }

    public Guid? CorrelationId { get; set; }

    public int Id { get; set; }
}
