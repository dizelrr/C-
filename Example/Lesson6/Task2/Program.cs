// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

int ReadInt(string msg)// объявляем функцию msg строковую
{
Console.WriteLine(msg);//пишет на экран параметр msg
string a = Console.ReadLine();
int numb;
numb = int.Parse(a);//преобразуем строку в число
return numb;// возврат из функции
}

bool chekTriangle(int a, int b, int c)
{
if ((a + b) > c && (a + c) > b && (b + c) > a)
{
return true;
}
return false;
}
int a = ReadInt("Введите длину первой стороны треугольника: ");
int b = ReadInt("Введите длину второй сторону треугольника: ");
int c = ReadInt("Введите длину третьей стороны треугольника: ");

System.Console.WriteLine(chekTriangle(a,b,c));
