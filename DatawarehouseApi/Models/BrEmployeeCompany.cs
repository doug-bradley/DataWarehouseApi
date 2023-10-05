using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class BrEmployeeCompany
{
    public long DimEmployeeId { get; set; }

    public long DimCompanyId { get; set; }

    public Guid? FxUserId { get; set; }

    public long? EmployeeId { get; set; }

    public long? CompanyId { get; set; }

    public string? DataSource { get; set; }

    public Guid? FxTenantId { get; set; }
}
