/*Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
453 -> 12
45 -> 9*/

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNumbers(int n)
{
    if (n == 0)
    {
        return 0;
    }
   
    return SumNumbers(n/10) + n%10;
    
}

int n = ReadInt("Введите число");

System.Console.WriteLine(SumNumbers(n));