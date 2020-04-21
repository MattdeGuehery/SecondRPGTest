using SecondRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG
{
    public class Location : ILocation
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public List<LocationOption> Options { get; set; }
        public int[] NextLocation { get; set; }


        public Location(int locationId, string locationName)
        {
            Id = locationId;
            Name = locationName;
            LocationOptions locationOptions = new LocationOptions(locationId);
            Options = locationOptions.Options;
        }

        public Location(int locationId)
        {
            Id = locationId;
            Locations Locations = new Locations();
            Location Location = Locations.FindLocation(Id);
            if (Location == null)
            {
                throw new Exception(string.Format("Unable to initialize Location for Id {0}", locationId));
            }
            else
            {
                LocationOptions locationOptions = new LocationOptions(locationId);
                Options = locationOptions.Options;
            }
        }

        public void DisplayOptions()
        {
            int i = 0;
            foreach (LocationOption option in Options)
            {
                i++;
                Console.WriteLine("Option {0}   |   {1}", i, option.Message);
            }
        }

    }
}
