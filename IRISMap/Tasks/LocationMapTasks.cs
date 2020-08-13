using System;
using System.Collections.Generic;
using System.Linq;
using IRISMap.Helpers;
using IRISMap.Interfaces;
using IRISMap.Models;
using IRISMap.ViewModels;

namespace IRISMap.Tasks
{

    public class LocationMapTasks : ILocationMapTasks
    {
        private readonly IRepository<Location> _repository;

        public LocationMapTasks(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Location> GetAllLocations()
        {
            return _repository.Entities;
        }

        public LocationMapViewModel GetMapMarkers()
        {
            var locations = GetAllLocations();
            var markers = GoogleMapsMarkerFormatter.Format(locations.ToList());

            var viewModel = new LocationMapViewModel
            {
                MapMarkers = markers
            };
            return viewModel;

        }
    }
}

