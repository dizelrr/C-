// Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество двузначных элементов массива.
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GenerateArray(int length = 20)// методы в сишарп с большой буквы.
{
int[] array = new int[length];// объявляем массив с таким размером
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(200);
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
int CountToDigit(int[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if (10 <= arr[i] && arr[i] < 100)
count++;

}
return count;
}
int [] Array=GenerateArray(10);
PrintArray(Array);
Console.WriteLine($"{CountToDigit(Array)}");