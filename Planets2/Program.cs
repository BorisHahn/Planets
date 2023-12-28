
namespace Planets2
{
    internal class Program
    {
        static internal void Main()
        {
            var venus = new Planet("Venus", 2, 38025);
            var earth = new Planet("Earth", 3, 40075, venus);
            var mars = new Planet("Mars", 4, 21344, earth);

            var catalogOfPlanets = new CatalogOfPlanets(venus, earth, mars);

            Console.WriteLine(catalogOfPlanets.GetPlanet("Earth"));
            Console.WriteLine(catalogOfPlanets.GetPlanet("Limonia"));
            Console.WriteLine(catalogOfPlanets.GetPlanet("Mars"));
        }
    }
}