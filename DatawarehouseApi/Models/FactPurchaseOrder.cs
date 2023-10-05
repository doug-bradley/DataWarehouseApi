using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactPurchaseOrder
{
    public long FactPurchaseOrderId { get; set; }

    public long DimCompanyId { get; set; }

    public long DimSupplierId { get; set; }

    public long DimEmployeeId { get; set; }

    public long? GlaccountGroupId { get; set; }

    public long? PoitemId { get; set; }

    public long? TenantId { get; set; }

    public long? Poid { get; set; }

    public long? RequestItemId { get; set; }

    public long? PodeliveryLocationId { get; set; }

    public string? PoitemDescription { get; set; }

    public long? CurrencyId { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public long? TaxRateId { get; set; }

    public string? TaxRateCode { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? ItemTaxSrc { get; set; }

    public decimal? ExclItemCostSrc { get; set; }

    public decimal? InclItemCostSrc { get; set; }

    public decimal? ExclItemCost { get; set; }

    public decimal? InclItemCost { get; set; }

    public decimal? ItemTax { get; set; }

    public decimal? UnitTaxSrc { get; set; }

    public decimal? UnitTax { get; set; }

    public decimal? ExclUnitCostSrc { get; set; }

    public decimal? ExclUnitCost { get; set; }

    public decimal? InclUnitCostSrc { get; set; }

    public decimal? InclUnitCost { get; set; }

    public long? PocurrentStateId { get; set; }

    public string? Poreference { get; set; }

    public DateTime? PocreationDate { get; set; }

    public long? CompanyId { get; set; }

    public long? SupplierId { get; set; }

    public long? PhysicalLocationId { get; set; }

    public long? InvoiceLocationId { get; set; }

    public long? PurchaserId { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public string? Pocomments { get; set; }

    public bool? PoisAcknowledged { get; set; }

    public bool? PoisQuery { get; set; }

    public string? CurrentState { get; set; }

    public decimal? ReceiptedAmount { get; set; }

    public decimal? InvoicedAmount { get; set; }

    public DateTime? PopurchasedAt { get; set; }

    public DateTime? PunchoutCompleteAt { get; set; }

    public DateTime? ClosedAt { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }
}
