namespace Planets3
{
    delegate string Validator();
    internal class Program
    {
        static internal void Main()
        {
            int countOfGetPlanet = 0;
            
            var venus = new Planet("Venus", 2, 38025);
            var earth = new Planet("Earth", 3, 40075, venus);
            var mars = new Planet("Mars", 4, 21344, earth);

            var catalogOfPlanets = new CatalogOfPlanets(venus, earth, mars);

            Validator planetValidator;
            planetValidator = PlanetValidator;

            string PlanetValidator()
            {
                ++countOfGetPlanet;
                return (countOfGetPlanet % 3 == 0) ? "Вы спрашиваете слишком часто" : "null";
            }
            
            Console.WriteLine(catalogOfPlanets.GetPlanet("Earth", planetValidator));
            Console.WriteLine(catalogOfPlanets.GetPlanet("Limonia", planetValidator));
            Console.WriteLine(catalogOfPlanets.GetPlanet("Mars", planetValidator));

        }
    }
}