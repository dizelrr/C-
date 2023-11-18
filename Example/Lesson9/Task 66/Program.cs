// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadInt(string msg)
{
    Console.Write(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

int CalcSumm (int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + CalcSumm (m + 1, n);
}

int m=ReadInt("Введите первое число: ");
int n=ReadInt("Введите второе число: ");

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

Console.WriteLine(CalcSumm (m, n));