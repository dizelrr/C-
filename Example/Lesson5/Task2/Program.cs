// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

// Замена знака.
void changeValueNumber(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] *= -1;
}
}

int[] numbers = generateArray(12, -9, 9);
printArray(numbers);
changeValueNumber(numbers);
printArray(numbers);