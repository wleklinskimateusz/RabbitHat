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

            Project Sudoku = new Project("SudokuSolver", "Unity", new DateTime(2020, 12, 28), "https://simmer.io/@matix0508/sudokusolver");
            Sudoku.Description = "Short Description";
            Sudoku.Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Sudoku_Puzzle_by_L2G-20050714_standardized_layout.svg/1200px-Sudoku_Puzzle_by_L2G-20050714_standardized_layout.svg.png";

            Project Sudoku2 = new Project("SudokuSolver", "Unity", new DateTime(2020, 12, 28), "https://simmer.io/@matix0508/sudokusolver");
            Sudoku2.Description = "Short Description";
            Sudoku2.Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Sudoku_Puzzle_by_L2G-20050714_standardized_layout.svg/1200px-Sudoku_Puzzle_by_L2G-20050714_standardized_layout.svg.png";
            var result = new List<Project>()
            {
                Sudoku,
                Sudoku2
            };

            Console.WriteLine("Hello");

            return new OkObjectResult(result.ToArray());
        }
    }
}
