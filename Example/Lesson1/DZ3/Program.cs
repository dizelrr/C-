// программа которая на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("НЕ четное число");
}