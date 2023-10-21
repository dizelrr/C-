// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// 1,0,1,1,0,1,0,0

int[] createMassive(int length)
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

void printMassive(int[] massive)
    { // выводим массив.
        foreach (var item in massive) // удобный метод вывода массива, создан специально для работы с коллекциями и массивами. Все ячейки внутри массива - это item.
            {
                Console.Write(item + " ");
            }
    }   

int[] massive = createMassive(6); // создаем массив
printMassive(massive); // выводим массив в консоль