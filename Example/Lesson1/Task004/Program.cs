// Другой способ показать по числу день недели
Console.WriteLine("Введите число от 1 до 7 ");
int num1  = int.Parse(Console.ReadLine());
string []days = {"пн","вт","ср","чет","пят","сб","вс"};
if (num1>=1 && num1<=7)
{
    Console.WriteLine(days[num1-1]);
}
else
{
    Console.WriteLine("Введите число от 1 до 7 ");
}