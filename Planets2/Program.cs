using System.Xml.Linq;

namespace Planets2
{
    internal class Program
    {
        static void Main()
        {
            var venus = new Planet("Venus", 2, 38025);
            var earth = new Planet("Earth", 3, 40075, venus);
            var mars = new Planet("Mars", 4, 21344, earth);
            var catalogOfPlanets = new CatalogOfPlanets(venus, earth, mars);
            catalogOfPlanets.GetPlanet("Venus");
            catalogOfPlanets.GetPlanet("Earth");
            catalogOfPlanets.GetPlanet("Mars");
            catalogOfPlanets.GetPlanet("Mars");
            catalogOfPlanets.GetPlanet("Earth");
            catalogOfPlanets.GetPlanet("Venus");

            catalogOfPlanets.GetPlanet("Limonia");
        }
    }
}