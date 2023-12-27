
namespace Planets2
{
    internal class Planet
    {
        public string Name {  get; set; }
        public int SerialNumber { get; set; }
        public int EquatorLength { get; set; }
        public object? PreviousPlanet { get; set; } = null;

        internal Planet(string name, int serialNumber, int equatorLength, object? previousPlanet = null) 
        {
            Name = name;
            SerialNumber = serialNumber;
            EquatorLength = equatorLength;
            PreviousPlanet = previousPlanet;
        }
    }
}
