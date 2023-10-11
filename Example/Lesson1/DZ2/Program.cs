// Программа которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("введите первое число");
string number1 = Console.ReadLine();
int a = int.Parse(number1);
Console.WriteLine ("введите первое число");
string number2 = Console.ReadLine();
int b = int.Parse(number2);
Console.WriteLine ("введите первое число");
string number3 = Console.ReadLine();
int c = int.Parse(number3);

int max = a;

if (max <  b)
{
    max = b;
}
if (max <  c)
{
    max = c;
}

Console.WriteLine("Максимальное число = " + max);