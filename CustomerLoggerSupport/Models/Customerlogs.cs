using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerLoggerSupport.Models
{
    public class Customerlogs
    {
        public int logid { get; set; }
        public string custemail { get; set; }
        public string custname { get; set; }
        public string logstatus { get; set; }
        public int userid { get; set; }
        public string desc { get; set; }
        
    }
}