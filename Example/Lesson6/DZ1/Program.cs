// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadInt(string msg)// объявляем функцию msg строковую
{
Console.WriteLine(msg);//пишет на экран параметр msg
string a = Console.ReadLine();
int numb;
numb = int.Parse(a);//преобразуем строку в число
return numb;// возврат из функции
}


int[] GlavArray (int length) // создаем массив и вводим чмисла пользователя
{
int[] array = new int[length];
for ( int i = 0; i < array.Length; i++ )
{
    array[i] = ReadInt($"Введите {i+1} элемент");
}
    return array;
}

void PrintArray (int[] array) // метод печать массива
{
    for( int i =0 ; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int SummaArray (int[]array)
    {
        int count = 0;
        for (int i=0 ; i< array.Length; i++)
        {
            if  (array[i] > 0)
            {
                count++;
            }
        }    
        return count;    
    }



int length = ReadInt("введите кол-во элементов"); //задаем сколько нам нужно элементов
int [] array; // создаем маасив
array = GlavArray(length); // заем его длину
PrintArray(array); // печатаем массив
System.Console.WriteLine();
System.Console.WriteLine($"количество больше 0 = {SummaArray(array)}");