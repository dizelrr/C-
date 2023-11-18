// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


void CreateMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j]= new Random().Next(1,10);
}
}
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]}\t");
}
Console.WriteLine();
}
}

int[] FindIndex(int[,] matrix)
{
int MinI=0;
int MinJ=0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (matrix[i,j]<matrix[MinI,MinJ])
{
MinI=i;
MinJ=j;
}
}
}
return new int[]{MinI,MinJ};
}

int[,] DeleteRowAndColumn(int[,] matrix, int MinI, int MinJ)
{
int[,] NewMatrix= new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i==MinI||j==MinJ)
{
continue;
}
int newIndex=0;
if (i<MinI)
{
newIndex=i;
}
if (i>MinI)
{
newIndex=i-1;
}
int newJindex=0;
if (j<MinJ)
{
newJindex=j;
}
if (j>MinJ)
{
newJindex=j-1;
}
NewMatrix[newIndex,newJindex]=matrix[i,j];
}
}
return NewMatrix;
}

int[,] matrix = new int[4,4];
CreateMatrix (matrix);
PrintMatrix(matrix);
Console.WriteLine();
int[] index=FindIndex(matrix);
int[,] NewMatrix=DeleteRowAndColumn(matrix,index[0], index[1]);
PrintMatrix(NewMatrix);