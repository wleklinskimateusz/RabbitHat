using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using BlazorApp.Client.Models;
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

            Project Sudoku = new Project("SudokuSolver", "Unity", new DateTime(2020, 12, 28), "https://simmer.io/@matix0508/sudokusolver");
            Sudoku.Description = "Short Description";
            var result = new List<Project>()
            {
                Sudoku
            };

            Console.WriteLine("Hello");

            return new OkObjectResult(result.ToArray());
        }
    }
}
