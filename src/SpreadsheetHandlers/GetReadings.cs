using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace SpreadsheetHandlers {
	public static class GetReadings {
		[FunctionName("GetReadings")]
		public static async Task<IActionResult> Run(
			[HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
			ILogger log) {
			log.LogInformation("C# HTTP trigger function processed a request.");

			string name = req.Query["name"];

			return name != null
				? (ActionResult)new OkObjectResult($"Hello, {name}")
				: new BadRequestObjectResult("Please pass a name on the query string or in the request body");
		}
	}
}
