﻿// программа которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int readQuoter(string message) // Функция для ввода переменных
    {
    System.Console.WriteLine(message); // получение данных из строки
    string value = Console.ReadLine(); //Вызов консольного ввода .Valve - значение которое вводим 
    return int.Parse(value); // возвращаем переменную в int
    }

int quoter = readQuoter ( " введите номер четверти ");
if  (quoter>0 & quoter<5)
    {
        if (quoter == 1)
        System.Console.WriteLine("x>0 & y>0");

        if (quoter == 2)
        System.Console.WriteLine("x<0 & y>0");
        
        if (quoter == 3)
        System.Console.WriteLine("x<0 & y<0");
    
        if (quoter == 4)
        System.Console.WriteLine("x>0 & y<0");
    }
else System.Console.WriteLine("данные ведены не верно");    

