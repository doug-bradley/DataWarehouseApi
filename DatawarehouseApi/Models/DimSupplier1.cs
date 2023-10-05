using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class DimSupplier1
{
    public long SupplierId { get; set; }

    public long? TenantId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Contact { get; set; }

    public string? PhoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string? Email { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? TaxRegistrationNumber { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? BankingInfo { get; set; }

    public string? PaymentTerms { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? Locality { get; set; }

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Coordinates { get; set; }

    public long? CreatedById { get; set; }

    public long? CurrentStateId { get; set; }

    public bool? IsActive { get; set; }

    public string? CustomColumns { get; set; }

    public Guid? FxSupplierId { get; set; }

    public long? CompanyId { get; set; }

    public long? CategoryId1 { get; set; }

    public long? CategoryId2 { get; set; }

    public long? CategoryId3 { get; set; }

    public long? ApprovalId { get; set; }

    public long? CurrencyId { get; set; }

    public string DataSource { get; set; } = null!;
}
