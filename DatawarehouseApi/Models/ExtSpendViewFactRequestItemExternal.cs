using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class ExtSpendViewFactRequestItemExternal
{
    public long? RequestItemId { get; set; }

    public long? TenantId { get; set; }

    public long? RequestItemTypeId { get; set; }

    public long? RequestId { get; set; }

    public long? ApprovalId { get; set; }

    public string? RequestItemDescription { get; set; }

    public DateTime? RequestItemDateStamp { get; set; }

    public decimal? RequestItemQuantity { get; set; }

    public decimal? RequestItemUnitCostSrc { get; set; }

    public bool? RequestItemIsInclusive { get; set; }

    public long? RequestItemCurrencyId { get; set; }

    public decimal? RequestItemExchangeRate { get; set; }

    public long? RequestItemTaxRateId { get; set; }

    public decimal? RequestItemTaxAmount { get; set; }

    public long? RequestItemApprovalId { get; set; }

    public long? RequestItemSupplierId { get; set; }

    public long? RequestItemDeliveryLocationId { get; set; }

    public long? RequestItemRequestorId { get; set; }

    public long? RequestItemServiceSupplierId { get; set; }

    public decimal? ExclUnitCostSrc { get; set; }

    public decimal? UnitTaxSrc { get; set; }

    public decimal? InclUnitCostSrc { get; set; }

    public decimal? ItemTaxSrc { get; set; }

    public decimal? ExclItemCostSrc { get; set; }

    public decimal? InclItemCostSrc { get; set; }

    public decimal? ExclUnitCost { get; set; }

    public decimal? UnitTax { get; set; }

    public decimal? InclUnitCost { get; set; }

    public decimal? ItemTax { get; set; }

    public decimal? ExclItemCost { get; set; }

    public decimal? InclItemCost { get; set; }

    public string? RequestItemTypeBaseResourceName { get; set; }

    public bool? RequestItemTypeBaseIsActive { get; set; }

    public DateTime? Watermark { get; set; }

    public long? RequestTypeId { get; set; }

    public long? RequestCurrentStateId { get; set; }

    public long? RequestReferenceNumber { get; set; }

    public string? RequestTitle { get; set; }

    public long? RequestRequestorId { get; set; }

    public long? RequestAssistantId { get; set; }

    public long? CompanyId { get; set; }
}
