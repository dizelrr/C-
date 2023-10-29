// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования



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

int[] CopyArray(int[] Array)
{
int [] NewArray = new int[Array.Length];
for (int i = 0; i < Array.Length; i++)
{
NewArray[i] = Array[i];
}
return NewArray;
}

int[] Array1 = generateArray(10, 0, 10);

printArray(Array1);

int[] Array2 = Array1;

Array1[0] = 100;
printArray(Array2);
printArray(Array1);


int[] Array3= CopyArray(Array1);
Array1[1] = 150;
printArray(Array3);
printArray(Array1);