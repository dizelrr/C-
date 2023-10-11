// Программа которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int N = int.Parse(number);
int n = 0;
while (n<N)
{
    n=n+2;
    Console.WriteLine(n);
}