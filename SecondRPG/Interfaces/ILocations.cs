using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG.Interfaces
{
    public interface ILocations
    {
        public Location SelectFirstLocation();
        public Dictionary<int, Location> InitializeLocations();
        public Location FindLocation(int locationId);
    }
}
