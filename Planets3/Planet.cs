
namespace Planets3
{
    internal class Planet
    {
        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public int EquatorLength { get; set; }
        public Planet PreviousPlanet { get; set; }

        internal Planet(string name, int serialNumber, int equatorLength, Planet previousPlanet = null)
        {
            Name = name;
            SerialNumber = serialNumber;
            EquatorLength = equatorLength;
            PreviousPlanet = previousPlanet;
        }
    }
}
