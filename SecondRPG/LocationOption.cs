using SecondRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG
{
    public class LocationOption : ILocationOption
    {
        public string Message { get; set; }
        public int Value { get; set; }
        public LocationOption(string message, int value)
        {
            Message = message;
            Value = value;
        }
    }
}
