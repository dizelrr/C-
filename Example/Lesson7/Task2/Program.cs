// // Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// */

int enterInteger(string message)
{
System.Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int[,] generateArray(int countCollums, int countLine, int a, int b){
int[,] array = new int[countLine, countCollums];
for (int i = 0; i < countCollums; i++)
{
for (int m = 0; m < countLine; m++)
{
array[m, i] = m+i;
}
}
return array;
}

void printMassive(int[,] collection){
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