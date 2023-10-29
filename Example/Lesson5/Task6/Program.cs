// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GenerateArray(int length = 20)// методы в сишарп с большой буквы.
{
int[] array = new int[length];// объявляем массив с таким размером
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(10);
}
return array;
}
void PrintArray(int[] array)
{
foreach (int item in array)// находим каждый элемент в массиве.
{
Console.Write(item + " ");
}
Console.WriteLine();
}
int ReadInt(string msg)
{
Console.Write(msg);
return int.Parse(Console.ReadLine());
}
int []CalculatePairs(int []array)
{
int []result=new int[array.Length/2+array.Length%2];
result[result.Length-1]=array[result.Length-1];
for (int i = 0; i < array.Length/2; i++)
{
result[i]=array[i]*array[array.Length-1-i];
}
return result;
}
int length=ReadInt("введите число ");
int []arr=GenerateArray(length);
PrintArray(arr);
PrintArray(CalculatePairs(arr));