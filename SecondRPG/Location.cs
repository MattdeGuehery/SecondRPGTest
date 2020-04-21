using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG
{
    class Location
    {

        private string locName;
        private int locID;
        private string[] locOpts;
        private int[] nextLocID;


        public Location(string LocName, int LocID)
        {

            string locName = LocName;
            int locID = LocID;

            LocationOptions locationOptions = new LocationOptions(LocID);
            locOpts = locationOptions.lOptions;

        }

        public void DisplayOptions()
        {
            int i = 1;
            foreach (string Options in locOpts)
            {                
                Console.WriteLine("Option {0}   |   {1}", i, Options); }
            }


    }
}
