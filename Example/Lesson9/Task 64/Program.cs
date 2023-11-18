// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNumbers(int i)
{
    if (i<=1){
        Console.Write($"{i}\t");
        return;
    }
    Console.Write($"{i}\t");
    PrintNumbers(i-1);
}

int i=ReadInt("Введите натуральное число: ");
while (i<1)
{
    Console.Write("Число не натуральное");
    i=ReadInt("Введите натуральное число: ");
}
PrintNumbers(i);