/*Определите, является ли число степенью двойки:
N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки”*/


int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool PowerSecond(int N)
{
    if (N==1)
    {
        return true;
    }
    
   
    return N%2==0 && PowerSecond(N/2);
    
}


int M = ReadInt("Введите число");

System.Console.WriteLine(PowerSecond(M));