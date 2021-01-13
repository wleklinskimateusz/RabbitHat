using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{
    public class Technology
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public Technology(string name)
        {
            Name = name;
        }

        public Technology(string name, string img)
        {
            Name = name;
            Image = img;
        }

        public Technology()
        {

        }
    }
}