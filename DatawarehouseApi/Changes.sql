--dotnet ef dbcontext scaffold "Server=eudwsqlserver.database.windows.net;Database=testDWDB;User Id=Fxdatafactory;password=AE9oKdiY&!#6k@;" Microsoft.EntityFrameworkCore.SqlServer 
--table "InvoiceExtractionLog" --table "RequestStateHistory" --table "BrProxy" --table "FactApproval" --table "BrApprover" --table "BrApprover" --table "Watermark"  --table "DimHoliday" --table "DimLocation" --table "DimEmployee" --table "DimEmployee" --table "FactEmployeeCompanyChangeHistory" --table "BrEmployeeCompany" --table "DimCompany" --table "EmployeeCompany" --table "WatermarkSPToSP" --table "EmployeeRole" --table "DimCurrency" --table "DimExchangeRate" --table "Role" --table "FactApprovalHistory" --table "FactPurchaseOrder" --table "DimExchangeRate" --table "FactPurchaseOrder" --table "DimCurrency" --table "FactRequest" --table "FactInvoice" --table "FactInvoice" --table "extSpend_viewFactRequestItemExternal" --table "DimRole" --table "Configuration" --table "BrEmployeeRole" --table "AvgRequestTurnaroundByTenant" --table "FactEmployeeRoleHistory" --table "TenantOutlier" --table "TenantRequestTurnaroundPercentile" --table "DimFinancialPeriod" --table "DimFinancialPeriod" --table "PopulationRequestTurnaroundPercentile" --table "FinancialPeriodDate" --table "FactEmployeeRoleHistory" --table "BrEmployeeApproval" --table "DimApproval" --table "FactBudget" --table "DimSupplier" --table "DimApproval" --table "DimSupplier" --table "FactBudget" --table "source" --table "CurrentStateLabels" --table "FactInvoiceItem" --table "WatermarkTableToSP" --table "FactReceipt" --table "FactReceipt" --table "DimGLAccount" --table "DimGLAccount" --table "DimCompany" --table "TenantURL" --table "BrGLAccountGroup" --table "FactRequest" --table "BrItemBudget" --table "TenantRequestToPurchasePercentileBenchmark" --table "FactApproval" --table "RequestToPurchasePercentileBenchmark" --table "FactRequestItem" --table "FactAlert" --table "FactAlert" --table "StoredProcedure" --table "TenantMonthlyRequestToPurchasePercentileBenchmark" --table "FactRequestStateHistory" --table "ApimLogs" --table "MonthlyRequestToPurchasePercentileBenchmark"  
-- -o Models

-- APExtractionStatistics

CREATE TABLE log.InvoiceExtractionLog (
    id INT PRIMARY KEY IDENTITY(1,1),
    TenantId UNIQUEIDENTIFIER,
    emailFrom NVARCHAR(255),
    userId BIGINT,
    correlationId UNIQUEIDENTIFIER,
    dateSubmitted DATETIME,
    invoiceNumber NVARCHAR(255) NULL,
    errorMessage NVARCHAR(255) NULL,
    status NVARCHAR(10)
);


CREATE TABLE log.APExtractionStatistics (
    id INT PRIMARY KEY IDENTITY(1,1),
    TenantId UNIQUEIDENTIFIER,
    InvoiceId BIGINT,
    Timestamp DATETIME,
    LoggingType NVARCHAR(255),
    Count INT,
    Exception NVARCHAR(MAX),
    Properties NVARCHAR(MAX),  -- Representing 'dynamic' type
    CorrelationId UNIQUEIDENTIFIER
);