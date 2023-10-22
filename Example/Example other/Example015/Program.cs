// сортировка массива
int  [] arr = {1,5,3,6,7,8,3,1}; // массив данные

void PrintArray(int[]array) //метод создания массива
    {
        int count = array.Length;
        for (int i = 0; i < count ; i++)
        {
            System.Console.Write($"{array[i]} ");
        }   
        System.Console.WriteLine();
    }

void SelectionSort ( int[] array) // фцункция сортировки массива
    {
        for ( int i=0; i<array.Length - 1 ; i++)
        {
            int minPosition = i;
            
            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
            }
            int temporary = array[i];
            array[i]=array[minPosition];
            array[minPosition] = temporary;
        }
    }    
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);