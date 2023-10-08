// проверка является ли чимло его квадратом
Console.WriteLine("введите число = ");
int inputData0 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число проверить = ");
int inputData1= int.Parse(Console.ReadLine());
if (inputData1 == inputData0*inputData0)
Console.WriteLine("yes");
    else Console.WriteLine("no");