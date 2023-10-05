using System;
using System.Collections.Generic;

namespace DataWarehouseApi.Models;

public partial class TenantUrl
{
    public string WebsiteUrl { get; set; } = null!;

    public string WebsiteSourceServer { get; set; } = null!;

    public string WebsiteInitialCatalog { get; set; } = null!;

    public string WebsiteDatasourceConcat { get; set; } = null!;

    public Guid FxTenantId { get; set; }

    public string DataSource { get; set; } = null!;
}
