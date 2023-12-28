
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
            string result = planetValidator(nameOfPlanet);
            if (result == "null" || result == "Это запретная планета")
            {
                var searchedPlanet = _listOfPlanet.Find(p => p.Name == nameOfPlanet);
                
                if (searchedPlanet != null)
                {
                    resultTuple = (searchedPlanet.SerialNumber, searchedPlanet.EquatorLength, "-");
                }
                else
                {
                    var msg = (result == "Это запретная планета") ? result : "Не удалось найти планету";
                    resultTuple = (0, 0, $"{msg}");

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
