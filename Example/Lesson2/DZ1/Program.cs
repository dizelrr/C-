// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int ReadInt(string msg)  
    {
    Console.WriteLine(msg); 
    string num = Console.ReadLine();  
    int number; 
    number = int.Parse(num);  
    return number; 
    }
int number = ReadInt("Введите трех значное число ");
if (number>99 & 1000>number)
    {   
        int SecondDigit=number/10%10;
        Console.WriteLine("вторая цифра " + SecondDigit);
    }   
else
    Console.WriteLine("чисол не трех значное" );