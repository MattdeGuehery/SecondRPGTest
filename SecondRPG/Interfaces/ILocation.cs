using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG.Interfaces
{
    public interface ILocation
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<LocationOption> Options { get; set; }
        public int[] NextLocation { get; set; }

        public void DisplayOptions();
    }
}
