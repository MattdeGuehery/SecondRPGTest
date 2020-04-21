using System;

namespace SecondRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Locations locs = new Locations();
            Location firstLocation = locs.SelectFirstLocation();
            firstLocation.DisplayOptions();
        }
    }
}
