
namespace Planets2
{
    internal class CatalogOfPlanets
    {
        private List<Planet> _listOfPlanet = new();
        private int _countOfGetPlanet = 0;

        public CatalogOfPlanets(params Planet[] val)
        {
            foreach (var item in val)
            {
                _listOfPlanet.Add(item);
            }
        }
        public (int serialNumber, int equatorLength, string errorMessage) GetPlanet(string nameOfPlanet)
        {
            (int, int, string) resultTuple;
            _countOfGetPlanet++;
            if (_countOfGetPlanet % 3 != 0)
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
            } else
            {
                resultTuple = (0, 0, "Вы спрашиваете слишком часто");
            }
            return resultTuple;
        }
    }
}
