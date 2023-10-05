using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class FactAlert
{
    public long FactAlertId { get; set; }

    public long? DimCompanyId { get; set; }

    public long? DimEmployeeId { get; set; }

    public long? CompanyId { get; set; }

    public long? AlertPolicyId { get; set; }

    public long? Poid { get; set; }

    public long? ProformaInvoiceId { get; set; }

    public long? InvoiceId { get; set; }

    public long? RequestId { get; set; }

    public long? AlertRecipientId { get; set; }

    public long? AlertId { get; set; }

    public long? RecipientId { get; set; }

    public DateTime? AlertRecipientCreationDate { get; set; }

    public long? AcknowledgedById { get; set; }

    public DateTime? AcknowledgedDate { get; set; }

    public bool? IsAcknowledged { get; set; }

    public DateTime? AlertCreationDate { get; set; }

    public string? AlertInfo { get; set; }

    public bool? IsActive { get; set; }

    public long? TenantId { get; set; }

    public string? AlertPolicyDescription { get; set; }

    public string? AlertTypeName { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }
}
