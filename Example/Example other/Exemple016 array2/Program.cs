// двух мерные массивы

string [,] table = new string [2,5];

table [1,2] = "слово";
for(int rows = 0; rows < 2; rows++)
{
    for(int colums=0; colums<5; colums++)
    {
        System.Console.WriteLine(($"{table[rows, colums]}--"));
    }
}

int [,] matrix = new int[3,4];
for (int i=0; i<3; i++)
{
    for(int j=0; j<4; j++)
    {
        System.Console.Write(($"{matrix[i,j]}"));
    }
System.Console.WriteLine();    
}

int [,] arr = new int[3,6];
for (int i=0; i<arr.GetLength(0); i++)
{
    for(int j=0; j<arr.GetLength(1); j++)
    {
        System.Console.Write(($"{arr[i,j]}"));
    }
System.Console.WriteLine();    
}
