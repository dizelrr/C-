// программа которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int enterCoordinate(string message) // Функция для ввода переменных
    {
    System.Console.WriteLine(message); // получение данных из строки
    string value = Console.ReadLine(); //Вызов консольного ввода .Valve - значение которое вводим 
    return int.Parse(value); // возвращаем переменную в int
    }

double resolveDistance(double x, double y, double x2, double y2) // функция обозначения координат и их рассчет
    { 
    double xDistance = (x - x2);
    double yDistance = (y - y2);
    double distance = Math.Sqrt(xDistance*xDistance + yDistance*yDistance);
    return distance;
    }

double x = enterCoordinate("Введите координату X 1 координаты: "); // вызов функции enterCoordinate
double y = enterCoordinate("Введите координату Y 1 координаты: ");
double x2 = enterCoordinate("Введите координату X 2 координаты: "); // вызов функции enterCoordinate
double y2 = enterCoordinate("Введите координату Y 2 координаты: ");

System.Console.WriteLine("Дистанция между двумя точками " + resolveDistance(x, y, x2, y2));