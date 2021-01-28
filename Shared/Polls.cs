using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    class Polls
    {
        public string Name;
        public string Topic;
        public string URL;

        public Polls()
        {

        }

        public Polls(string name, string topic, string url)
        {
            Name = name;
            Topic = topic;
            URL = url;
        }
    }
}
