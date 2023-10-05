using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class EmployeeCompany
{
    public long? EmployeeId { get; set; }

    public long? CompanyId { get; set; }

    public string? DataSource { get; set; }
}
