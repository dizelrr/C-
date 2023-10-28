// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Функция генерации массива
int[] GenerateArray(int length, int minValue, int maxValue)
{
int[] numbers = new int[length]; // Создаем пустой массив (все элемента = 0)
Random random = new Random(); // создание генератора случайных чисел
for (int i = 0; i < numbers.Length; i++) // заполнение массива случайными числами
{
numbers[i] = random.Next(minValue, maxValue + 1); // заполнение текущего элемента массива случайным числом в диапазоне [minValue..maxValue]
}
return numbers;
}

// Функция вывода массива на экран
void PrintArray(int[] array)
{
System.Console.Write(array[0]); // Вывод 1-го элемента массива
for (int i = 1; i < array.Length; i++)
{
System.Console.Write($", {array[i]}"); // Вывод текущего элемента массива
}
System.Console.WriteLine(); // Перевод строки (чтобы отделять массивы)
}

// Функция подсчета суммы положительных элементов
int SumPositive(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
{
sum += array[i];
}
}
return sum;
}

// Функция подсчета суммы отрицательных элементов
int SumNegative(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] < 0)
{
sum += array[i];
}
}
return sum;
}

// Функция подсчета и положительных и отрицательных
int SumSign(int[] array, int sign)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] * sign > 0)
{
sum += array[i];
}
}
return sum;
}

int[] arr = GenerateArray(12, -9, 9); // Генерация массива из 12 элементов от -9 до 9
PrintArray(arr); // Вывод массива
System.Console.WriteLine("Сумма положительных элементов равна " + SumPositive(arr));
System.Console.WriteLine($"Сумма отрицательных элементов равна {SumNegative(arr)}");
System.Console.WriteLine($"Сумма отрицательных {SumSign(arr, -1)}, положительных {SumSign(arr, 1)}");