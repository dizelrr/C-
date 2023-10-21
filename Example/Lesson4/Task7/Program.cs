// Программа создает случайныке числа и сортирует их

int [] createMassive(int Length)
{
int [] massive = new int [Length]; // создание массива длинной Length
int i = 0;// объявляем счетчик (будет играть роль индекса)
while (i < massive.Length) // заполнение массива случайными числами
{
massive[i]= new Random().Next(10);
i++;
}
return massive;
}
void printMassive(int [] massive)
{

foreach (var item in massive) // перебирает все элементы массива и выводит на экран
{
Console.Write(item + " ");
}
}

void sortMassive(int [] massive)
{
for (int i = 0; i < massive.Length; i++)
{
int localMinIndex= minIndex(i,massive);
int save = massive[localMinIndex];
massive[localMinIndex]=massive[i];
massive[i]= save;


}
}

int minIndex(int start, int [] massive) // поиск индекса по минимуму начиная с эл-та старт
{
int min= start;
for (int i= start; i<massive.Length; i++)
{
if (massive[min]>massive[i])
{
min=i;
}
}
return min;
}


int [] massive = createMassive(6);
printMassive(massive);
sortMassive(massive);
Console.WriteLine();
printMassive(massive);