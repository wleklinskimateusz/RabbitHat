using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using BlazorApp.Shared;
using System.Collections.Generic;

namespace BlazorApp.Api
{
    public static class ProjectsFunction
    {
        [FunctionName("Projects")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {

            // Console.WriteLine("Hello");

            return new OkObjectResult(Project.GetExample());
        }
    }
}
