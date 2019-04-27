﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DreamLifeWeb_api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //Enable Cors
            //config.EnableCors();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                //routeTemplate: "api/{controller}/{id}",
                routeTemplate: "trips/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
