// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNaturalNum(int M, int N)
{
    if (N < M)
    {
        return;
    }
    System.Console.Write($"{M}\t");
    PrintNaturalNum(M + 1, N);
    
}


int M = ReadInt("Введите первое число");
int N = ReadInt("Введите второе число");
PrintNaturalNum(M, N);