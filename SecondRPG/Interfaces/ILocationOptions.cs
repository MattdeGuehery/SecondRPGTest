using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRPG.Interfaces
{
    public interface ILocationOptions
    {
        public int Id { get; set; }
        public List<LocationOption> Options { get; set; }
    }
}
