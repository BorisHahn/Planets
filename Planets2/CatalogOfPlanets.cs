
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
        public void GetPlanet(string nameOfPlanet)
        {
            _countOfGetPlanet++;
            if (_countOfGetPlanet % 3 != 0)
            {
                var searchedPlanet = _listOfPlanet.Find(p => p._name == nameOfPlanet);
                if (searchedPlanet != null)
                {
                    Console.WriteLine($"Запрашиваемая планета - {nameOfPlanet}");
                    Console.WriteLine("Результат поиска: Планета найдена");
                    Console.WriteLine($"Название - {searchedPlanet._name}");
                    Console.WriteLine($"Порядковый номер от Солнца - {searchedPlanet._serialNumber}");
                    Console.WriteLine($"Длина экватора - {searchedPlanet._equatorLength}");
                }
                else
                {
                    Console.WriteLine($"Запрашиваемая планета - {nameOfPlanet}");
                    Console.Write("Результат поиска: ");
                    Console.WriteLine("Не удалось найти планету");
                }
            } else
            {
                Console.WriteLine("Вы спрашиваете слишком часто");
            }
            Console.WriteLine("__________________________________________");
        }
    }
}
