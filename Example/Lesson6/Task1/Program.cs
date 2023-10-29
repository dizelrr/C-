//  Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// */

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


void printArray(int[] array)
{
System.Console.Write(array[0]); // Вывод 1-го элемента массива
for (int i = 1; i < array.Length; i++)
{
System.Console.Write($", {array[i]}"); // Вывод текущего элемента массива
}
System.Console.WriteLine(); // Перевод строки (чтобы отделять массивы)
}

int[] reverseArray(int[] Array)
{
for (int i = 0; i < Array.Length/2; i++)
{
int A = Array[i];
Array[i]=Array[Array.Length - 1 - i] ;
Array[Array.Length - 1 - i] = A;
}
return Array;
}
int [] newArray = generateArray(5, 0, 10);
printArray(newArray);

printArray (reverseArray(newArray));