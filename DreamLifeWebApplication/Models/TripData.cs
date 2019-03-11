/*
  Model create to represent the data of each trip
  This model was based on the trips.json file
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamLifeWebApplication.Models
{

    public class TripData
    {
        public TripData() { }

        public string HotelName { get; set; }

        public string Thumb { get; set; }

        public int Stars { get; set; }

        public string Location { get; set; }

        public City City { get; set; }

        public string Country { get; set; }

        public DateTime Date { get; set; }

        public int Price { get; set; }

        public string Class { get; set; }

        public int Guest { get; set; }
    }

    public class City
    {

        public string Id { get; set; }
        public string Name { get; set; }
    }

    
}