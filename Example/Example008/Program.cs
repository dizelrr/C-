// Одномерный массив array из n элементов . Нахождение элемента массива равное find

int[] array  = {1,20,34,35,657,45,56,67,345,767,45,4};
int n = array.Length;
int find =4;
int index = 0;

while(index < n)
    {
        if ( array[index] == find)
        {
            Console.WriteLine(index);
        }
        index++; // плюс один или после плюса цифра на сколько 
    }
