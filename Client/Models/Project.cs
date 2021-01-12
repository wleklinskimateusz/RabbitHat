using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Models
{
    public class Project
    {
        public string Name { get; set; }
        public List<Technology> Technologies { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        
        public Project(string name, List<Technology> techs, DateTime start, DateTime end)
        {
            Name = name;
            Technologies = techs;
            StartingTime = start;
            EndTime = end;
        }
        public Project()
        {

        }
        public Project(string name, List<string> techs, DateTime start, DateTime end)
        {
            Name = name;
            Technologies = StringToTech(techs);
            StartingTime = start;
            EndTime = end;
        }

        List<Technology> StringToTech(List<string> lst)
        {
            List<Technology> output = new List<Technology>();
            foreach(var item in lst)
            {
                output.Add(new Technology(item));
            }
            return output;
        }
    }
}
