// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да */

// Функция генерации массива
int[] generateArray(int length, int minValue, int maxValue)
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
void printArray(int[] array)
{
System.Console.Write(array[0]); // Вывод 1-го элемента массива
for (int i = 1; i < array.Length; i++)
{
System.Console.Write($", {array[i]}"); // Вывод текущего элемента массива
}
System.Console.WriteLine(); // Перевод строки (чтобы отделять массивы)
}

bool searchNumbers(int[] array, int number)
{
for (int i = 0; i < array.Length; i++)
{
if(array[i] == number){
return true;
}
}
return false;
}

int[] collections = generateArray(12, -9, 9);
printArray(collections);
Console.WriteLine(searchNumbers(collections, 1) ? "Да" : "Нет");