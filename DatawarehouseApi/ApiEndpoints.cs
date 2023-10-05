using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace DataWarehouseApi
{
	public enum Period
	{
        Month = 1,
        Quarter = 2,    
        Year = 3
	}

	public class ApStatistics
	{
		public Period Period { get; set; }
		public decimal CurrentPeriodValue { get; set; }
		public decimal PreviousPeriodValue { get; set; }
		public decimal ChangePercentage =>
			(PreviousPeriodValue == 0) ? 0 : Math.Round(((CurrentPeriodValue - PreviousPeriodValue) / PreviousPeriodValue) * 100, 2);
		public decimal ChangeAmount => (CurrentPeriodValue - PreviousPeriodValue);
	}

    public class ApiEndpoints
    {

        private readonly ILogger _logger;

        public ApiEndpoints(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<ApiEndpoints>();
        }

        [Function("InvoicesProcessedCount")]
        public HttpResponseData InvoicesProcessedCount([HttpTrigger(AuthorizationLevel.Function, "get"
															, Route = "apStatistics/{fxTenantId}/InvoicesProcessedCount")] HttpRequestData req
															, string fxTenantId)
        {
	        var queryOptions = req.GetQueryOptions(fxTenantId);
	        var period = Enum.Parse<Period>(queryOptions.Period, true);

			// Create an object for demo, you should replace this with your actual data
			var statistics = new ApStatistics
	        {
		        Period = period,
		        CurrentPeriodValue = 100 * (int)period,
		        PreviousPeriodValue = 80 * (int)period
			};
	        return req.BuildResponse(JsonSerializer.Serialize(statistics));
        }

        [Function("EmailReceivedCount")]
        public HttpResponseData EmailReceivedCount([HttpTrigger(AuthorizationLevel.Function, "get", Route = "apStatistics/{fxTenantId}/EmailReceivedCount")] HttpRequestData req, string fxTenantId)
        {
			var queryOptions = req.GetQueryOptions(fxTenantId);
			var period = Enum.Parse<Period>(queryOptions.Period, true);

			// Create an object for demo, you should replace this with your actual data
			var statistics = new ApStatistics
			{
				Period = period,
				CurrentPeriodValue = 110 * (int)period,
				PreviousPeriodValue = 90 * (int)period
			};
			return req.BuildResponse(JsonSerializer.Serialize(statistics));
		}

        [Function("EmailErrorCount")]
        public HttpResponseData EmailErrorCount(
												[HttpTrigger(AuthorizationLevel.Function, "get", Route = "apStatistics/{fxTenantId}/EmailErrorCount")] HttpRequestData req, string fxTenantId)
        {
			var queryOptions = req.GetQueryOptions(fxTenantId);
			var period = Enum.Parse<Period>(queryOptions.Period, true);

			// Create an object for demo, you should replace this with your actual data
			var statistics = new ApStatistics
			{
				Period = period,
				CurrentPeriodValue = 1 * (int)period,
				PreviousPeriodValue = 8 * (int)period
			};
			return req.BuildResponse(JsonSerializer.Serialize(statistics));
		}

        [Function("InvoicePagesCount")]
        public HttpResponseData InvoicePagesCount([HttpTrigger(AuthorizationLevel.Function, "get", Route = "apStatistics/{fxTenantId}/InvoicePagesCount")] HttpRequestData req, string fxTenantId)
        {
			var queryOptions = req.GetQueryOptions(fxTenantId);
			var period = Enum.Parse<Period>(queryOptions.Period, true);

			// Create an object for demo, you should replace this with your actual data
			var statistics = new ApStatistics
			{
				Period = period,
				CurrentPeriodValue = 180 * (int)period,
				PreviousPeriodValue = 125 * (int)period
			};
			return req.BuildResponse(JsonSerializer.Serialize(statistics));
		}

        [Function("AveragePagesPerInvoice")]
        public HttpResponseData AveragePagesPerInvoice([HttpTrigger(AuthorizationLevel.Function, "get", Route = "apStatistics/{fxTenantId}/AveragePagesPerInvoice")] HttpRequestData req, string fxTenantId)
        {
			var queryOptions = req.GetQueryOptions(fxTenantId);
			var period = Enum.Parse<Period>(queryOptions.Period, true);

			// Create an object for demo, you should replace this with your actual data
			var statistics = new ApStatistics
			{
				Period = period,
				CurrentPeriodValue = 129 * (int)period,
				PreviousPeriodValue = 101 * (int)period
			};
			return req.BuildResponse(JsonSerializer.Serialize(statistics));
		}

        [Function("AverageItemsPerInvoice")]
        public HttpResponseData AverageItemsPerInvoice([HttpTrigger(AuthorizationLevel.Function, "get", Route = "apStatistics/{fxTenantId}/AverageItemsPerInvoice")] HttpRequestData req, string fxTenantId)
        {
			var queryOptions = req.GetQueryOptions(fxTenantId);
			var period = Enum.Parse<Period>(queryOptions.Period, true);

			// Create an object for demo, you should replace this with your actual data
			var statistics = new ApStatistics
			{
				Period = period,
				CurrentPeriodValue = 239 * (int)period,
				PreviousPeriodValue = 173 * (int)period
			};
			return req.BuildResponse(JsonSerializer.Serialize(statistics));
		}
	}

}
