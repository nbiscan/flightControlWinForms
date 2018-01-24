using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightControlApi.Models
{
    public class Plane
    {
        public   Int64 Id { get; set; }
        public   string Model { get; set; }
        public   string SerialNumber { get; set; }
        public   Int64 EconomyCapacity { get; set; }
        public   Int64 BusinessCapacity { get; set; }
        public   Int64 FirstClassCapacity { get; set; }
        public   int Active { get; set; }
    }
}