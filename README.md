## Planets

### Программа 1.

Создать четыре объекта анонимного типа для описания планет Солнечной системы со свойствами "Название", "Порядковый номер от Солнца", "Длина экватора", "Предыдущая планета" (ссылка на объект - предыдущую планету):
* Венера
* Земля
* Марс
* Венера (снова)
Данные по планетам взять из открытых источников.
Вывести в консоль информацию обо всех созданных "планетах". Рядом с информацией по каждой планете вывести эквивалентна ли она Венере.

### Программа 2.

Написать обычный класс "Планета" со свойствами "Название", "Порядковый номер от Солнца", "Длина экватора", "Предыдущая планета" (ссылка на предыдущую Планету).
Написать класс "Каталог планет". В нем должен быть список планет - при создании экземпляра класса сразу заполнять его тремя планетами: Венера, Земля, Марс.
Добавить в класс "Каталог планет" метод "получить планету", который на вход принимает название планеты, а на выходе дает три поля: первые два поля порядковый номер планеты от Солнца и длину ее экватора, когда планета найдена, а последнее поле - для ошибки. В случае, если планету по названию найти не удалось, то этот метод должен возвращать строку "Не удалось найти планету" (именно строку, не Exception). На каждый третий вызов метод "получить планету" должен возвращать строку "Вы спрашиваете слишком часто".
В main-методе Вашей программы создать экземпляр "Каталога планет". У этого каталога вызвать метод "получить планету", передав туда последовательно названия Земля, Лимония, Марс. Для найденных планет в консоль выводить их название, порядковый номер и длину экватора. А для ненайденных выводить строку ошибки, которую вернул метод "получить планету".

### Программа 3.

Скопировать решение из программы 2, но переделать метод "получить планету" так, чтобы он на вход принимал еще один параметр, описывающий способ защиты от слишком частых вызовов - делегат PlanetValidator (можно вместо него использовать Func), который на вход принимает название планеты, а на выходе дает строку с ошибкой. Метод "получить планету" теперь не должен проверять сколько вызовов делалось ранее. Вместо этого он должен просто вызвать PlanetValidator и передать в него название планеты, поиск которой производится. И если PlanetValidator вернул ошибку - передать ее на выход из метода третьим полем.
Из main-метода при вызове "получить планету" в качестве нового параметра передавать лямбду, которая делает всё ту же проверку, которая была и ранее - на каждый третий вызов она возвращает строку "Вы спрашиваете слишком часто" (в остальных случаях возвращает null). Результат исполнения программы должен получиться идентичный программе 2.
