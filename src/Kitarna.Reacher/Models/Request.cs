using System;
using System.Collections.Generic;

namespace Kitarna.Reacher.Models
{
    public class Request
    {
        public Uri URL {get;set;}
        public List<KeyValuePair<string, string>> Headers {get;set;}
        public string Body { get; set; }
    }
}