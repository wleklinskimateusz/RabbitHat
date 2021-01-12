using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Models
{
    public class Technology
    {
        public string Name { get; set; }

        public Technology(string name)
        {
            Name = name;
        }
    }
}
