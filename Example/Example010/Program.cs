void FillArray(int[] collection)   // метод заполнения массива

    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection [index] = new Random().Next(1,6);
            index++;
        }
    }

void PrintArray(int[] col)   // метод печати массива
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.WriteLine(col[position]);
            position++;
        }
    }

int indexOf(int[]collection, int find)  //метод     
    {
        int count = collection.Length;
        int index = 0;
        int position = 0;
        while (index < count)
        {
            if(collection[index] == find)
            {
                position = index;
            }
            index++;
        }
        return position;
    }

int[] array = new int [13];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);