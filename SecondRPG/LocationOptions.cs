using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG
{
    class LocationOptions
    {
        public string[] lOptions;
        public Dictionary<int, int[]> locDict = new Dictionary<int, int[]>
        {
            { 1, new [] {1,2,3} }  

        };
        public LocationOptions(int LocationID)
        {
            Options CurrentOptions = new Options(locDict[LocationID]);
            lOptions = CurrentOptions.OptionMsg;
        }



    }
}
