// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string msg)  // обьявляем Реддит и строковый параметр msg
    {

        Console.WriteLine(msg); // пишет в консоль параметр msg
        string num = Console.ReadLine(); // функция считывает строки с консоля терминала 
        int number; // добавляем переменную намбер
        number = int.Parse(num);  // как результат преобразования строки в число
        return number; // возврат из функции
    }
int[] GenArr(int length)
    { // создание массива, указание длины.
        int[] massive = new int [length]; // создаем новый массив с указанием размера.
        int i = 0;
        while(i < massive.Length)
            { 
                // пока счётчик меньше размера массива
                massive[i] = new Random().Next(2); // заполняем рандомными числами 0-1, не включая 2;
                i++;
            }
        return massive; // возвращаем массив.
    }

int length = ReadInt("Введите  число ");
int min = ReadInt("Введите  число ");
int max = ReadInt("Введите  число ");
int [] array = GenArr (length,min,max);

PrintArray(array);