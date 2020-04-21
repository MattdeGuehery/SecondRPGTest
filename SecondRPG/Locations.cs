using SecondRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG
{
    public class Locations : ILocations
    {
        private Dictionary<int, Location> locations = new Dictionary<int, Location>();

        public Locations()
        {
            InitializeLocations();
        }

        public Location SelectFirstLocation()
        {
            return locations[1];
        }

        public Dictionary<int, Location> InitializeLocations()
        {
            locations.Add(1, new Location(1, "Test Location 1"));
            locations.Add(2, new Location(2, "Test Location 2"));
            return locations;
        }

        public Location FindLocation(int locId)
        {
            Location _loc;
            if (locations.TryGetValue(locId, out _loc))
            {
                return _loc;
            }
            return null;
        }

    }
}
