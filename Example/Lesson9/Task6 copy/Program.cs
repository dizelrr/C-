
/*Проверка на простое число: 
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число”*/

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
bool SimpleNumb(int numb, int div = 0)
{
    if (div == 0)
    {
        div = numb - 1;
    }
    if (div == 1)
    {
        return true;
    }
    return numb % div != 0 && SimpleNumb(numb, div - 1);
}
int M = ReadInt("Введите число");

System.Console.WriteLine(SimpleNumb(M));