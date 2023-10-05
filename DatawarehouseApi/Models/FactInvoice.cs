using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactInvoice
{
    public long FactInvoiceId { get; set; }

    public long? DimCompanyId { get; set; }

    public long? DimEmployeeId { get; set; }

    public long? DimSupplierId { get; set; }

    public long? DimApprovalId { get; set; }

    public long? DimCurrencyId { get; set; }

    public long? GlaccountGroupId { get; set; }

    public long? InvoiceItemId { get; set; }

    public long? TenantId { get; set; }

    public long? RequestItemTypeId { get; set; }

    public long? InvoiceId { get; set; }

    public string? InvoiceItemDescription { get; set; }

    public decimal? InvoiceItemQuantity { get; set; }

    public decimal? UnitCostSrc { get; set; }

    public bool? IsInclusive { get; set; }

    public long? CurrencyId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public long? TaxRateId { get; set; }

    public decimal? TaxAmount { get; set; }

    public long? Poid { get; set; }

    public long? PoitemId { get; set; }

    public long? ApprovalId { get; set; }

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

    public long? CurrentStateId { get; set; }

    public string? InvoiceRef { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public long? SupplierId { get; set; }

    public long? ProcessorId { get; set; }

    public long? CompanyId { get; set; }

    public long? InvoiceMpId { get; set; }

    public short? UpdateVersion { get; set; }

    public string? ExInvoiceRef { get; set; }

    public bool? ExIsError { get; set; }

    public decimal? ItemTaxTotal { get; set; }

    public bool? IsItemTax { get; set; }

    public DateTime? PostingDate { get; set; }

    public double? DaysFromRequestToPo { get; set; }

    public double? DaysFromPotoInvoice { get; set; }

    public string? CurrentState { get; set; }

    public DateTime? PreApproveAt { get; set; }

    public DateTime? PreApproveCcat { get; set; }

    public DateTime? ApproveAt { get; set; }

    public DateTime? ApproveCcat { get; set; }

    public DateTime? QuotePendingAt { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ClosedAt { get; set; }
}
