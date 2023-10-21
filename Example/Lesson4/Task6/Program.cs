// Напишите программу, которая выводит массив из 8 элементов,
// // заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]  и сортируем их

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
// var j;
// int k;
foreach (var item in massive) // перебирает все элементы массива и выводит на экран
{
Console.Write(item + " ");
}
}

void sortMassive(int [] massive)
{
for (int i = 0; i < massive.Length; i++)
{
for (int j = 0; j<massive.Length-1; j++)
{
if (massive[j]>massive[j+1])
{
int save = massive[j+1];
massive[j+1]=massive[j];
massive[j]= save;
}
}
}
}

int [] massive = createMassive(6);
printMassive(massive);
sortMassive(massive);
Console.WriteLine();
printMassive(massive);