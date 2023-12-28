
using System.ComponentModel.DataAnnotations;

namespace Planets3
{
    internal class CatalogOfPlanets
    {
        private List<Planet> _listOfPlanet = new();

        public CatalogOfPlanets(params Planet[] val)
        {
            foreach (var item in val)
            {
                _listOfPlanet.Add(item);
            }
        }
        public (int serialNumber, int equatorLength, string errorMessage) GetPlanet(string nameOfPlanet, Validator planetValidator)
        {
            (int, int, string) resultTuple;
            string result = planetValidator();
            if (result == "null")
            {
                var searchedPlanet = _listOfPlanet.Find(p => p.Name == nameOfPlanet);
                if (searchedPlanet != null)
                {
                    resultTuple = (searchedPlanet.SerialNumber, searchedPlanet.EquatorLength, "-");
                }
                else
                {
                    resultTuple = (0, 0, "Не удалось найти планету");

                }
            }
            else
            {
                resultTuple = (0, 0, result);
            }
            return resultTuple;
        }
    }
}
