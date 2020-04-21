using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG
{
    public class Options
    {
        public Dictionary<int, string> optDic = new Dictionary<int, string> 
        {
            {1, "Approach the Castle" },
            {2, "Visit the Healer" },
            {3, "Go to the Blacksmith" },
        };
        public string[] OptionMsg;

        public Options(int[] optionsSelected)      // int[] {1, 2, 3}
        {
            for (int i = 0; i < optionsSelected.Length; i++)
            {
                OptionMsg[i] = optDic[optionsSelected[i+1]];
            }
        }
    }









}
