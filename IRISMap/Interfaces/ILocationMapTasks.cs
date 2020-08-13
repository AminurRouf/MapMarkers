using System.Collections.Generic;
using IRISMap.Models;
using IRISMap.ViewModels;

namespace IRISMap.Interfaces
{
    public interface ILocationMapTasks
    {
        IEnumerable<Location> GetAllLocations();
        LocationMapViewModel GetMapMarkers();
    }

}