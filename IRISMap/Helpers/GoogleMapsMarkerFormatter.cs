using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IRISMap.Models;

namespace IRISMap.Helpers
{
    public class GoogleMapsMarkerFormatter
    {
        public static string Format(List<Location> locations)
        {
            string mapMarkers = "[";
            foreach (var location in locations)
            {
                mapMarkers += "{";
                mapMarkers += $"'title': '{location.Name}',";
                mapMarkers += $"'lat': '{location.Latitude}',";
                mapMarkers += $"'lng': '{location.Longitude}',";
                mapMarkers += "},";
            }
            mapMarkers += "];";
            return mapMarkers;
        }
    }
}