//  Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1/


int enterInteger(string message)
{
System.Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int[,] generateArray(int countCollums, int countLine, int a, int b) // создание двухмерного массива
{
int[,] array = new int[countLine, countCollums];
Random random = new Random();
for (int i = 0; i < countCollums; i++)
{
for (int m = 0; m < countLine; m++)
{
array[m, i] = random.Next(a, b);
}
}
return array;
}

void printMassive(int[,] collection) // заполнение массива случайными числами
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

int countCollums = enterInteger("Введите количество колоннок массива: ");
int countLine = enterInteger("Введите количество строк массива: ");

int[,] array = generateArray(countCollums, countLine, 1, 9);
printMassive(array);