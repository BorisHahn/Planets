namespace Planets3
{
    delegate string Validator(string name);
    delegate string LimoniaValidate(string name);

    internal class Program
    {
        static internal void Main()
        {
            int countOfGetPlanet = 0;
            
            var venus = new Planet("Venus", 2, 38025);
            var earth = new Planet("Earth", 3, 40075, venus);
            var mars = new Planet("Mars", 4, 21344, earth);
            
            var catalogOfPlanets = new CatalogOfPlanets(venus, earth, mars);

            LimoniaValidate validateLimonia;
            validateLimonia = LimoniaValidator;

            string LimoniaValidator(string nameOfPlanet)
            {
                return (nameOfPlanet == "Limonia") ? "Это запретная планета" : "null";
            }

            Validator planetValidator;
            planetValidator = PlanetValidator;

            string PlanetValidator(string arg1)
            {
                ++countOfGetPlanet;
                return (countOfGetPlanet % 3 == 0) ? "Вы спрашиваете слишком часто" : $"{validateLimonia(arg1)}";
            }

            

            Console.WriteLine(catalogOfPlanets.GetPlanet("Earth", planetValidator));
            Console.WriteLine(catalogOfPlanets.GetPlanet("Limonia", planetValidator));
            Console.WriteLine(catalogOfPlanets.GetPlanet("Mars", planetValidator));
            Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", planetValidator));
            Console.WriteLine(catalogOfPlanets.GetPlanet("Earth", planetValidator));


        }
    }
}