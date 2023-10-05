using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactReceipt
{
    public long FactReceiptId { get; set; }

    public long? ReceiptId { get; set; }

    public long? TenantId { get; set; }

    public long? PoitemId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? UnitCostSrc { get; set; }

    public bool? IsActive { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public DateTime? DateReceived { get; set; }

    public long? ReceiverId { get; set; }

    public DateTime? Watermark { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }
}
