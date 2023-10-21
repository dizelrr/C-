// Программа которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// // 89126 -> 5

int ReadInt(string msg)  // обьявляем Реддит и строковый параметр msg
    {

        Console.WriteLine(msg); // пишет в консоль параметр msg
        string num = Console.ReadLine(); // функция считывает строки с консоля терминала 
        int number; // добавляем переменную намбер
        number = int.Parse(num);  // как результат преобразования строки в число
        return number; // возврат из функции
    }
int Digit = ReadInt("Ввидите число: ");
int n =  0;
while (Digit>0)
    {
        Digit/=10;
        n=n+1;
    }
    System.Console.WriteLine("Колличество цифр в числе = " +n);