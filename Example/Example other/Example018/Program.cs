int[,] pic = new int [,] // можем не указывать сколько строк и столбцов если массив задаем с данными
{
    {0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,1,1,1,1},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,1,1,1,1},
    {0,0,0,0,0,1,1,0,0,1,0,0,0,0,1,0,0,1,1,1,1},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,1,1,1,1},
    {0,0,0,0,0,1,1,0,0,1,0,0,0,0,1,0,0,1,1,1,1},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,1,1,1,1},
    {1,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,1,1,1,1},
    {0,1,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,1,1,1,1},
    {0,0,1,0,0,1,0,0,0,1,0,0,0,0,1,0,0,1,1,1,1},
    {0,0,1,0,0,1,1,1,1,1,1,1,1,1,1,0,0,1,1,1,1},
};

void PrintImage(int[,]image) // этим методом задаем символы коотрые нам нужны
{for (int i=0; i<image.GetLength(0); i++)
{
    for(int j=0; j<image.GetLength(1); j++)
    {
        if(image[i,j] ==0) System.Console.Write($" ");
        else System.Console.Write($"+");
    }
System.Console.WriteLine();    
}
}

void FillImage(int row, int col) // метод  который нам поможет закрасить 
{
    if (pic[row,col] == 0)
    {
        pic[row,col] = 1;
        FillImage(row-1,col);
        FillImage(row,col-1);
        FillImage(row+1,col);
        FillImage(row,col+1);
    }
}

PrintImage(pic);
System.Console.WriteLine();
FillImage(7,8);
PrintImage(pic);