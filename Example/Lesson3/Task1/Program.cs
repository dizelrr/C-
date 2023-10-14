// программа которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int enterCoordinate(string message) // Функция для ввода переменных
    {
    System.Console.WriteLine(message); // получение данных из строки
    string value = Console.ReadLine(); //Вызов консольного ввода .Valve - значение которое вводим 
    return int.Parse(value); // возвращаем переменную в int
    }

bool checkValidate (int x, int y) // проверка ввода икс и игрика что не равны нулю
    {
        if (x == 0 || y == 0) // занчит || - или
        {
        Console.WriteLine("Координаты икс или игрик равны нулю");
        return false; //проверку не прошла
        }
        return true; //проверку прошла
    }

int checkCategory (int x, int y) // определение где находится координата
    {
        if  ( x>0 && y>0) // определение номера четыверти
        {
            return 1 ;
        }
        if  ( x<0 && y>0)

        {
            return 2 ;
        }
         if  ( x<0 && y<0)
        {
            return 3 ;
        }

        return 4; // остаток если все false
    
       }
int x = enterCoordinate("Введите координату X: "); // вызов функции координат
int y = enterCoordinate("Введите координату Y: ");

if (checkValidate(x,y)) // исполняемый код
    {
        System.Console.WriteLine("Номер четверти равен" + checkCategory(x,y));
    }