// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string msg)  
    {
    Console.WriteLine(msg); 
    string num = Console.ReadLine();  
    int number; 
    number = int.Parse(num);  
    return number; 
    }
int Summa( int number)
    {
        result = 0;
        while (number > 0)
            {
                result += number%10;
                number = number/10;
            }
                return result;
    }


int number = ReadInt("Введите  число ");

System.Console.WriteLine($"Сумма цифр в числе = {Summa( int number)}");