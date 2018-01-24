using System;

namespace FlightControlApi.Models
{
    public class Airport
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public Int64 CountryId { get; set; }
        //public MsSql2008GeographyType Location { get; set;}
        //public ISet<Country> Country { get; set; }

    }
}