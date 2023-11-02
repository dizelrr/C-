

double[,] vozvrat= new double[m,n];
for(int i=0; i<m ; i++)
{
for(int j=0; j<n ; j++)
{
    vozvrat[i,j] = new Random().NextDouble() + new Random().Next(minLimitRandom, maxLimitRandom);
}
}
return vozvrat;




for(int i=0 ; i<matrix.Length; i++ )
{
    for(int i=0 ; j<matrix.Length; i++ )
    {
        System.Console.WriteLine(${"matrix[i,j]:f2\t"});
    }
}