// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ReadInt(string msg)  
    {
    Console.WriteLine(msg); 
    string num = Console.ReadLine();  
    int number; 
    number = int.Parse(num);  
    return number; 
    }
int number = ReadInt("Введите  число ");
while ( number > 999)
    {
        number = number/10;
    }
if (number > 99 )
    {
        int result = number % 10;
        Console.WriteLine(result);
    }
if (number < 100 )
    {
        Console.WriteLine("третьей цифры нету");
    }