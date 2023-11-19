// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}
void EvenNumbers(int m, int n)
{
    if (m<=n)
    {
        if (m%2==0)
        {
            System.Console.Write($"{m}\t");
        }
        EvenNumbers(m + 1, n);
          return ;
    }
}
int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите чисол n: ");
EvenNumbers(m, n);

