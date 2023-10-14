// программа которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y). swith используется

int readQuoter(string message) // Функция для ввода переменных
    {
    System.Console.WriteLine(message); // получение данных из строки
    string value = Console.ReadLine(); //Вызов консольного ввода .Valve - значение которое вводим 
    return int.Parse(value); // возвращаем переменную в int
    }

int quoter = readQuoter ( " введите номер четверти ");
if  (quoter>0 & quoter<5)
    {
        switch(quoter)
        {
            case 1: System.Console.WriteLine("x>0 & y>0");break;
            case 2: System.Console.WriteLine("x<0 & y>0");break;
            case 3: System.Console.WriteLine("x<0 & y<0");break;
            case 4: System.Console.WriteLine("x>0 & y<0");break;
            
        }
       
    }
else System.Console.WriteLine("данные ведены не верно");    