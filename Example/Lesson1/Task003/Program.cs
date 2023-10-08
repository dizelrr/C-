// Будет выдавать какой день недели по числу 

Console.WriteLine("Введите число от 1 до 7 ");
int num1  = int.Parse(Console.ReadLine());
if (num1 == 1)
{
    Console.Write("понедельник");
}
else if (num1 == 2)
{
    Console.Write("вотрник");
}
else if (num1 == 3)
{
    Console.Write("среда");
}
else if (num1 == 4)
{
    Console.Write("четверг");
}
else if (num1 == 5)
{
    Console.Write("пятница");
}
else if (num1 == 6)
{
    Console.Write("суббота");
}
else if (num1 == 7)
{
    Console.Write("воскресенье");
}
else
{
     Console.Write("это не то число");
}

