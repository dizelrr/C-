// Программа которая принимает трех значное число и в конце выдает последнию его цифру

Console.WriteLine("Введите число ");
string num = Console.ReadLine();
int number;
number = int.Parse(num);
if (number>99 & 1000>number)
    {   
        int lastDigit=number%10;
        Console.WriteLine("последняя цифра " + lastDigit);
    }   
else
    Console.WriteLine("чисол не трех значное" );