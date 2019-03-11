/*
 Controller responsible to manager the trips data retrived from the json file and send to the View component
 */

using DreamLifeWebApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DreamLifeWebApplication.Controllers
{
    public class TripsController : Controller
    {
        // GET: Trips
        public ActionResult City(string GetTripsByCity)
        {

            //Reading from the json file 
            var webClient = new WebClient();
            string fileName = Server.MapPath("~/App_Data/trips.json");
            var json = webClient.DownloadString(fileName);     
            IList<TripData> tripsData = JsonConvert.DeserializeObject<IList<TripData>>(json);

            TripsCollection tripsCollection = new TripsCollection(tripsData);
            
            //Calling the FilterResult function to filter trips by CityID and DateTime
            TripsCollection tripsCollectionFiltered = FilterResult(tripsCollection, GetTripsByCity);

            return View(tripsCollectionFiltered);
        }

       
        
        //Filtering JSON results by CityID and DateTime (date later than today's date)
        public TripsCollection FilterResult(TripsCollection tripsData, string GetTripsByCity)
        {

            TripsCollection tripsCollectionFiltered = new TripsCollection();

         

            foreach (TripData trip in tripsData.tripsCollection)
            {
                //Filtering Trips by CityID
                if (trip.City.Id.Equals(GetTripsByCity))
                {
                    //Date condition (later than today)
                    if (DateTime.Compare(trip.Date, DateTime.Today) > 0)
                    {
                        tripsCollectionFiltered.tripsCollection.Add(trip);
                    }
               
                }

                
            }

            return tripsCollectionFiltered;
        }

    }
}