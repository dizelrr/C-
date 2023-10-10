 // Поиск максимального числа в массиве

 int Max(int arg1, int arg2, int arg3)
{
 int result = arg1;
 if(arg2 > result) result = arg2;
 if(arg3 > result) result = arg3;
return result;
}

int[] array = {11, 22, 33, 44, 556, 66 ,77 ,88, 99};


int result = Max(
    Max (array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);