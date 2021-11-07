using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TextGameV2.Domain.Map
{
    public class LocationFactory : ILocationFactory
    {
        private readonly List<Location> _locations;

        public LocationFactory()
        {
            var fileName = "Configs/Locations.json.txt";
            var jsonString = File.ReadAllText(fileName);
            _locations = JsonSerializer.Deserialize<List<Location>>(jsonString);
        }

        public ILocation CreateLocation()
        {
            var rd = new Random();
            var randomloc = rd.Next(0, 9);

            return _locations[randomloc];
        }
    }
}
