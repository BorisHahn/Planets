using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets3
{
    internal class Planet
    {
        public string _name {  get; set; }
        public int _serialNumber { get; set; }
        public int _equatorLength { get; set; }
        public object? _previousPlanet { get; set; } = null;

        internal Planet(string name, int serialNumber, int equatorLength, object? previousPlanet = null) 
        {
            _name = name;
            _serialNumber = serialNumber;
            _equatorLength = equatorLength;
            _previousPlanet = previousPlanet;
        }
    }
}
