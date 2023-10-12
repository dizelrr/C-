// напишите программу которая выводит случайное число из отрезка 10 до 100 и показыввает и показывает наибольшую цифру числа

int number = new Random().Next(10,100); // генерирует случайное число и перемещает в переменную намбер 
Console.WriteLine("число" + number);
int firstDigit = number / 10;
int lastDigit = number % 10;
if (firstDigit > lastDigit)
    {
        Console.WriteLine(firstDigit);
    }
else
    {
    Console.WriteLine(lastDigit);
    }    
