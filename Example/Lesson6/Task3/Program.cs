// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ReadInt(string msg)// объявляем функцию msg строковую
{
Console.WriteLine(msg);//пишет на экран параметр msg
string a = Console.ReadLine();
int numb;
numb = int.Parse(a);//преобразуем строку в число
return numb;// возврат из функции
}
// переводим десятичное число в двоичное

int [] binaryArray(int number)
{
int [] bynary = new int[8];
for (int i = bynary.Length-1; i >=0; i--)
{
bynary[i]=number%2;
number=number/2;
}
return bynary;
}


void printArray(int[] array)
{
System.Console.Write(array[0]);
for (int i = 0; i < array.Length; i++)
{
System.Console.Write($"{array[i]}");
}
System.Console.WriteLine();
}

int number = ReadInt("Введите число больше 0");
printArray(binaryArray(number));