/*Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int PowerNumber(int M, int N)
{
    if (N ==0)
    {
        return 1;
    }
    return PowerNumber(M,N-1)*M;
    
}


int M = ReadInt("Введите основание");
int N = ReadInt("Введите степень");
System.Console.WriteLine(PowerNumber(M, N));