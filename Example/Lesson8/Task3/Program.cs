// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9

int[] CreateArray(int Length) // меотд создания массива
{
int [] Array = new int[Length];
Random random = new Random();
for (int i = 0; i < Array.Length; i++)
{
Array[i] = random.Next(0, 10);

}
return Array;
}

void PrintArray (int[] Array) //печатаем массив метод
{
for (int i = 0; i < Array.Length; i++)
{
System.Console.Write(Array[i]);
System.Console.Write(" ");
}
System.Console.WriteLine();
}

int [] CountFrequency (int [] Array) // метод посчета элементов входных данных
{
int [] FrequencyArray = new int [10];
for (int i = 0; i < Array.Length; i++)
{

FrequencyArray[Array[i]]++;

}
return FrequencyArray;
}

int [] Array = CreateArray(30);

PrintArray(Array);

int [] newArray = CountFrequency(Array);
PrintArray(newArray);