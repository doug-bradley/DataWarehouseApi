using System.Net;
using Microsoft.Azure.Functions.Worker.Http;

namespace DataWarehouseApi
{
	public static class HttpRequestDataExtensions
	{
		public static (string Period, string CompanyId, string FxTenantId) GetQueryOptions(this HttpRequestData req, string fxTenantId)
		{
			return (
				Period: req.Query["period"] ?? "month",
				CompanyId: req.Query["companyId"] ?? string.Empty,
				FxTenantId: fxTenantId
			);
		}

		public static HttpResponseData BuildResponse(this HttpRequestData req, string responseJson)
		{
			var response = req.CreateResponse(HttpStatusCode.OK);
			response.Headers.Add("Content-Type", "application/json; charset=utf-8");
			response.WriteString(responseJson);
			return response;
		}
	}
}