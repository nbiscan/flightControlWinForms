using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightControlApi.Models
{
    public class Pilot
    {
        public   Int64 Id { get; set; }
        public   string FirstName { get; set; }
        public   string LastName { get; set; }
        public   DateTime BirthDay { get; set; }
        public   bool Active { get; set; }
    }
}