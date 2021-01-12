using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Models
{
    public class Project
    {
        public string Name { get; set; }
        public Technology Technology { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        
        public Project(string name, Technology techs, DateTime start, DateTime end)
        {
            Name = name;
            Technology = techs;
            StartingTime = start;
            EndTime = end;
        }
        public Project()
        {

        }

        public Project(string name, string tech, DateTime start)
        {
            Name = name;
            Technology = new Technology(tech);
            StartingTime = start;
        }

        public Project(string name, string tech, DateTime start, string url)
        {
            Name = name;
            Technology = new Technology(tech);
            StartingTime = start;
            URL = url;
        }
    }
}
