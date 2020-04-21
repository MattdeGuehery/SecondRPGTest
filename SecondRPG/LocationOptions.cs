using SecondRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG
{
    public class LocationOptions : ILocationOptions
    {
        public int Id { get; set; }
        public List<LocationOption> Options { get; set; }
        private Dictionary<int, LocationOption> optionLocationReference = new Dictionary<int, LocationOption>
        {
            {1, new LocationOption("Approach the Castle", 1) },
            {2, new LocationOption("Visit the Healer", 2) },
            {3, new LocationOption("Go to the Blacksmith", 3) },
            {4, new LocationOption("Return To Town", 4) },
        };
        
        private Dictionary<int, int[]> locationReference = new Dictionary<int, int[]>
        {
            { 1, new [] {1,2,3} },
            { 2, new [] {2,3,4} },
        };

        public LocationOptions(int locationId)
        {
            Id = locationId;
            int[] locationIds;
            if (locationReference.TryGetValue(locationId, out locationIds))
            {
                Options = new List<LocationOption>();
                foreach (int id in locationIds)
                {
                    LocationOption locOpts;
                    if (optionLocationReference.TryGetValue(id, out locOpts))
                    {
                        Options.Add(locOpts);
                    }
                }
            }
        }

    }
}
