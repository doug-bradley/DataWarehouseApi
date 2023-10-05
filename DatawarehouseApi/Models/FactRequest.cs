using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactRequest
{
    public long FactRequestId { get; set; }

    public long? DimCompanyId { get; set; }

    public long? DimSupplierId { get; set; }

    public long? DimEmployeeId { get; set; }

    public long? DimApprovalId { get; set; }

    public long? DimCurrencyId { get; set; }

    public long? GlaccountGroupId { get; set; }

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

    public long? RequestTypeId { get; set; }

    public long? RequestCurrentStateId { get; set; }

    public long? RequestReferenceNumber { get; set; }

    public string? RequestTitle { get; set; }

    public long? RequestRequestorId { get; set; }

    public long? RequestAssistantId { get; set; }

    public long? CompanyId { get; set; }

    public string? RequestTypeBaseResourceName { get; set; }

    public bool? RequestTypeBaseIsActive { get; set; }

    public string? RequestItemTypeBaseResourceName { get; set; }

    public bool? RequestItemTypeBaseIsActive { get; set; }

    public DateTime? PreApproveAt { get; set; }

    public DateTime? PreApproveCcat { get; set; }

    public DateTime? QuotePendingAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? RejectedAt { get; set; }

    public DateTime? CanceledAt { get; set; }

    public string? CurrentState { get; set; }

    public string? DataSource { get; set; }

    public DateTime? ApproveSubmitAt { get; set; }

    public DateTime? ApproveCompleteAt { get; set; }

    public DateTime? ApproveSubmitCcat { get; set; }

    public DateTime? ApproveCompleteCcat { get; set; }

    public DateTime? AutoApproveAt { get; set; }

    public Guid? FxTenantId { get; set; }
}
