// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int ReadInt(string message)
    {
    System.Console.WriteLine(message); // Получаем данные из строки.
    string value = Console.ReadLine(); // Вызов консольного ввода, value - значение, которое вводим.
    return int.Parse(value);
    }
int N = ReadInt("введите положительное число");
if (N > 0)
    {
    int index = 0;
    while (index < N)
        {
        index++;
        Console.WriteLine (index*index);
        }

    }
else Console.WriteLine ("число введено неверно. Введите положительное число");