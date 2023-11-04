//  Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12

int enterInteger(string message)
{
System.Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int[,] generateArray(int count, int a, int b)
{
int[,] array = new int[count, count];
Random rndArray = new Random();
for (int i = 0; i < count; i++)
{
for (int m = 0; m < count; m++)
{
array[m, i] = rndArray.Next(a, b);
}
}
return array;
}

int findSumDiag (int [,] array)
{
int Sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if (i==j)
{
Sum += array[i, j];
}
}

}
return Sum;
}

void printMassive(int[,] collection)
{
for (int i = 0; i < collection.GetLength(0); i++)
{
Console.WriteLine();
for (int m = 0; m < collection.GetLength(1); m++)
{
Console.Write($"{collection[i, m]} \t");
}
}
Console.WriteLine();
}

int count = enterInteger("Введите количество колоннок и строк массива: ");

int[,] array = generateArray(count, 1, 9);

printMassive(array);


System.Console.WriteLine(findSumDiag(array));