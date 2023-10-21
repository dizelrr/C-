// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

using System.Globalization;

int Prompt(string message)
    {
        System.Console.Write(message);
        string value = Console.ReadLine();
        int result = Convert.ToInt32(value);
        return result;
    }
int summ = 0;
int number = Prompt("Введите цисло для подсчета суммы: ");
while(number > 0 )
    {
        summ = summ + number;
        number --;
    }
Console.WriteLine("Сумма чисел = " + summ);