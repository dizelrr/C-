// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int enterInteger(string message)
{
System.Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

void printMassive(int[] collection){
foreach (var item in collection)
{
Console.Write($"{item} ");
}
}

int[] fibonachiNumber(int number){
int[] massive = new int[number];
if(number != 0){
massive[0] = 0;
if(number > 1){
massive[1] = 1;
for (int i = 2; i < number; i++)
{
massive[i] = massive[i-1] + massive[i-2];
}
}
}
return massive;
}

int number = enterInteger("Введите любое положительное число: ");
int[] array = fibonachiNumber(number);
printMassive(array);