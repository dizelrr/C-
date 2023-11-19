// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadInt(string msg)
{
    Console.Write(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}
int summ (int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + summ (m + 1, n);
}
int m=ReadInt("Введите 1 число: ");
int n=ReadInt("Введите 2 число: ");
if (m > n)
{
    int a = m;
    m = n;
    n = a;
}
Console.WriteLine(summ (m, n));