// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int ReadInt(string message) // метод вводим значения
{
Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

int[,] CreateMatrix(int row, int col) // метод  создаем массив
{
int[,] matrix = new int[row, col];
for (int i = 0; i <row; i++)
{
for (int j = 0; j < col; j++)
{
matrix[i,j]= new Random().Next(1,10);
}
}
return matrix;
}

int[,] ChangeMatrix(int[,] matrix) // меняем стори на столбцы
{
int temp = 0;

for (int i = 0; i <matrix.GetLength(0); i++)
{
for (int j = i+1; j < matrix.GetLength(1); j++)
{
temp = matrix[i,j];
matrix[i,j] = matrix[j,i];
matrix[j,i] = temp;
}
}
return matrix;
}

void PrintMatrix(int[,] matrix) // метод печатаем массив 
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


int row = ReadInt("Введите количество строк: ");
int col = ReadInt("Введите количество столбцов: ");
if (row != col)
{
Console.WriteLine("Матрица не квадратная");
}
else
{
int[,] matrix = CreateMatrix(row, col);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(ChangeMatrix(matrix));
}