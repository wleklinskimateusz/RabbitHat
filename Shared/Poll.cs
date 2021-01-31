using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class Poll
    {
        public string Name;
        public string Topic;
        public string URL;

        public Poll()
        {

        }

        public Poll(string name, string topic, string url)
        {
            Name = name;
            Topic = topic;
            URL = url;
        }
    }
}
