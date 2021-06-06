using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using TextGameV2.Domain;

namespace TextGameV2
{
    public static class LocationFactory
    {
        private static readonly List<Location> _locations;

        static LocationFactory()
        {
            var fileName = "Configs/Locations.json.txt";
            var jsonString = File.ReadAllText(fileName);
            _locations = JsonSerializer.Deserialize<List<Location>>(jsonString);
        }

        public static ILocation CreateLocation()
        {
            var rd = new Random();
            var randomloc = rd.Next(0, 7);
            
            return _locations[randomloc];
        }
    }
}
