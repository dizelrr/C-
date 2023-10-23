﻿// Разница между максимальным и минимальным элементами массива
// Напишите программу для работы с массивом вещественных чисел.

// Реализуйте класс ArrayOperations, который содержит следующие статические методы:

// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.

// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.

// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.

// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.

// Аргументы, передаваемые в метод/функцию:

// '3.17, 8.94, 2.36, 5.72, 0.85'
// На выходе:


// Массив:
// 3.17    8.94    2.36    5.72    0.85    
// Разность между максимальным и минимальным элементом = 8.09

using System;

public class Answer
{
    public static double FindMax(double[] array)
    {     // Введите свое решение ниже
double maxNumber = array[0];
      for(int i=0; i<array.Length; i++)
      {
        if (array[i]>maxNumber)
        {
          maxNumber = array[i];
        }
      }
return maxNumber;
       
    }

    public static double FindMin(double[] array)
    {     // Введите свое решение ниже
      
double minNumber = array[0];
      for(int i=0; i<array.Length; i++)
      {
        if (array[i]<minNumber)
        {
          minNumber = array[i];
        }
      }
      return minNumber;


    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {// Введите свое решение ниже
double  difBetweenMaxMin = FindMax(array) - FindMin(array);
  return difBetweenMaxMin;


    }

    public static void PrintArray(double[] array)
    {// Введите свое решение ниже
for(int i=0; i < array.Length; i++)
{
  Console.Write($"{array[i]:F2}\t");
}
Console.WriteLine();
    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}