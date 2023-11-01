void PrintArray(int[,]arr)
{for (int i=0; i<arr.GetLength(0); i++)
{
    for(int j=0; j<arr.GetLength(1); j++)
    {
        System.Console.Write(($"{arr[i,j]} "));
    }
System.Console.WriteLine();    
}
}
void FillArray (int[,]arr) // метод заполняем массив случайными числами
{
    for (int i=0; i<arr.GetLength(0); i++)
{
    for(int j=0; j<arr.GetLength(1); j++)
    {
       arr[i,j] = new Random().Next(1,9); 
    }
}
}
int [,] arr = new int[3,6]; // задаем 3 строки 6 столбцов

PrintArray(arr);
FillArray(arr);
System.Console.WriteLine();
PrintArray(arr);