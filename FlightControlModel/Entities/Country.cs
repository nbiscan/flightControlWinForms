using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FlightControlApi.Models
{
    public class Country
    {
        public   Int64 Id { get; set; }
        public   string iso { get; set; }
        public   string name { get; set; }
        public   string printable_name { get; set; }
        public   string iso3 { get; set; }
        public   int numcode { get; set; }
       
    }
}