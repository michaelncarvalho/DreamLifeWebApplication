/*
  Model to represent the collection of Trips read from the trip.json file
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamLifeWebApplication.Models
{

    public class TripsCollection
    {
        public TripsCollection(IList<TripData> tripsCollection) => this.tripsCollection = tripsCollection;

        public TripsCollection() => tripsCollection = new List<TripData>();

        public IList<TripData> tripsCollection { get; set; }
    }
}

    