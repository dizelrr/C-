// метод создания массива и его печать 

void FillArray(int[] collection)

    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection [index] = new Random().Next(1,50);
            index++;
        }
    }   // метод заполнения массива

void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.WriteLine(col[position]);
            position++;
        }
    } // метод печати массива



int[] array = new int [13];
FillArray(array);
PrintArray(array);