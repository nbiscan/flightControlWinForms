﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightControlApi.Models
{
    public class Flight
    {
        public virtual Int64 Id { get; set; }
        public virtual Int64 RouteId { get; set; }
        public virtual Int64 PlaneId { get; set; }
        public virtual Int64 PilotId { get; set; }
        public virtual DateTime DepTime { get; set; }
        public virtual DateTime ArrTime { get; set; }
        public virtual bool Canceled { get; set; }
        public virtual Decimal Price { get; set; }
    }
}