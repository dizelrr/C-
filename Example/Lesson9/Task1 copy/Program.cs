/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

void PrintNaturalNumbers(int number)
{
    if (number <=0)
    {
        return;
    }
    PrintNaturalNumbers(number-1);
    System.Console.Write($"{number}\t");
}

PrintNaturalNumbers(9);
