int[] createMassive(int length){ // создание массива, указание длины.
int[] massive = new int [length]; // создаем новый массив с указанием размера.
int i = 0;
while(i < massive.Length){ // пока счётчик меньше размера массива
massive[i] = new Random().Next(1, 10); // заполняем рандомными числами 0-1, не включая 2;
i++;
}
return massive; // возвращаем массив.
}

void printMassive(int[] massive){ // выводим массив.
foreach (var item in massive) // удобный метод вывода массива, создан специально для работы с коллекциями и массивами. Все ячейки внутри массива - это item.
{
Console.Write(item + " ");
}
Console.WriteLine();
}

void sortMassive(int[] massive){
for(int i = 0; i < massive.Length-1; i++){ // отвечает за перебор всех элементов массива
for(int m = 0; m < massive.Length-1; m++){ // отвечает за сортировку n-ого элемента массива.
if(massive[m] > massive[m+1]){
int save = massive[m+1];
massive[m+1] = massive[m];
massive[m] = save;
}
Console.Write(m + " = ");
printMassive(massive);
}
printMassive(massive);
}
}

int[] massive = createMassive(8); // создаем массив
printMassive(massive); // выводим массив в консоль
sortMassive(massive);
Console.WriteLine();
printMassive(massive);