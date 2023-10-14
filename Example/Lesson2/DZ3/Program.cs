// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string msg)  
    {
    Console.WriteLine(msg); 
    string num = Console.ReadLine();  
    int number; 
    number = int.Parse(num);  
    return number; 
    }
int number = ReadInt("введите день недели");
if  (number > 0 & number < 6)
    {
        Console.WriteLine("нет");
    }
if (number  > 5 & number < 8)
    {
        Console.WriteLine("да");
    }
if (number > 7)
    {
        Console.WriteLine("нету такого дня недели");
    }    