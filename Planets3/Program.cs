namespace Planets3
{
    internal class Program
    {
        static void Main()
        {
            int countOfGetPlanet = 0;
            Func<string?> PlanetValidator = () =>
            {
                ++countOfGetPlanet;
                if (countOfGetPlanet % 3 == 0) return "Вы спрашиваете слишком часто";
                else return null;
            };
            var venus = new Planet("Venus", 2, 38025);
            var earth = new Planet("Earth", 3, 40075, venus);
            var mars = new Planet("Mars", 4, 21344, earth);
            var catalogOfPlanets = new CatalogOfPlanets(venus, earth, mars);
            catalogOfPlanets.GetPlanet("Venus", PlanetValidator());
            catalogOfPlanets.GetPlanet("Earth", PlanetValidator());
            catalogOfPlanets.GetPlanet("Mars", PlanetValidator());
            catalogOfPlanets.GetPlanet("Mars", PlanetValidator());
            catalogOfPlanets.GetPlanet("Earth", PlanetValidator());
            catalogOfPlanets.GetPlanet("Venus", PlanetValidator());

            catalogOfPlanets.GetPlanet("Limonia", PlanetValidator());
        }
    }
}