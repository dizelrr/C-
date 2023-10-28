// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// другой вариант


int[] GenerateArray(int lenght, int minValue, int maxValue)

{

int[] numbers = new int[lenght];
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
{
numbers[i] = random.Next(minValue, maxValue + 1);
}
return numbers;
}

void PrintArray(int[] array)
{
System.Console.Write(array[0]);
for (int i = 1; i < array.Length; i++)
{

System.Console.Write($", {array[i]}");
}
System.Console.WriteLine();
}

int[] ArraChanging(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array [i]= array[i]*-1;
}
return array;

}

int[] arr = GenerateArray(12, -9, 9);
PrintArray(arr);
PrintArray (ArraChanging(arr));