//  Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.

// 1 4 7 2
// 5 9 2 3



// 1 4 7 2
// 5 81 2 9



int enterInteger(string message)
{
System.Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int[,] generateArray(int countCollums, int countLine, int a, int b)
{
int[,] array = new int[countLine, countCollums];
Random rndArray = new Random();
for (int i = 0; i < countCollums; i++)
{
for (int m = 0; m < countLine; m++)
{
array[m, i] = rndArray.Next(a, b);
}
}
return array;
}

int[,] changeElements(int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if (i % 2 > 0 & j % 2 > 0)
{
array[i, j] *= array[i, j];
}
}

}
return array;
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

int countCollums = enterInteger("Введите количество колоннок массива: ");
int countLine = enterInteger("Введите количество строк массива: ");


int[,] array = generateArray(countCollums, countLine, 1, 9);

printMassive(array);

changeElements(array);

printMassive(array);