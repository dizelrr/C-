// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadInt(string msg)  // обьявляем Реддит и строковый параметр msg
    {

        Console.WriteLine(msg); // пишет в консоль параметр msg
        string num = Console.ReadLine(); // функция считывает строки с консоля терминала 
        int number; // добавляем переменную намбер
        number = int.Parse(num);  // как результат преобразования строки в число
        return number; // возврат из функции
    }

int searchFactorial(int number)
    {
        int i = 1;
        int result = 1;
        while(i <= number)
            {
                result *= i;
                i++;
            }
        return result;
    }

int number = ReadInt("Введите число: ");
Console.WriteLine(searchFactorial(number));