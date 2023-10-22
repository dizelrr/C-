// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

int ReadInt(string msg)  // функция ввода числа
    {
    Console.WriteLine(msg); 
    string num = Console.ReadLine();  
    int number; 
    number = int.Parse(num);  
    return number; 
    }
int  Step( int number1, int number2)  // расчитываем степень числа
    {
        int step = 1;
        for ( int i = 0; i < number2 ; i++)
        {
            step *= number1;
        }
        return step;
    }    

int number1 = ReadInt("Введите  число ");
int number2 = ReadInt("Введите  число степени ");

    
System.Console.WriteLine($"число {number1} в степени {number2} = {Step(number1,number2)}");




