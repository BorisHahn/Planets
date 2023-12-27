using System.Numerics;

namespace Planets
{
    internal class Program
    {
        static void Main()
        {
   
            var venus = new { Name = "Venus", SerialNumber = 2, EquatorLength = 38025, PreviousPlanet = "" };
            var earth = new { Name = "Earth", SerialNumber = 3, EquatorLength = 40075, PreviousPlanet = venus.Name };
            var mars = new { Name = "Mars", SerialNumber = 4, EquatorLength = 21344, PreviousPlanet = earth.Name };
            var venusDuplicate = new { Name = "venusDuplicate", SerialNumber = 2, EquatorLength = 38025, PreviousPlanet = mars.Name };
            var planets = new[]
            {
                venus,
                earth, 
                mars,
                venusDuplicate,
            };

            for ( int i = 1; i < planets.Length; i++ )
            {
                var equalResult = planets[i].EquatorLength.Equals(planets[0].EquatorLength) ? "is equal to Venus" : "is Not equal to Venus";
                Console.WriteLine($"{planets[i]} {equalResult}");
            }
        }   
    }
}