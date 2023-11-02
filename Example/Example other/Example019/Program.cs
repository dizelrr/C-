// нахождеине факториала

// 1*2*3=6  факториал числа 3

double Factorial (int n)
{
    //1 факотриал = 1
    // 0 факториал = 1
    if(n==1) return 1;
    else return n*Factorial(n-1);
} 
for (int i=1; i<40; i++)
System.Console.WriteLine($"{i}! ={Factorial(i)}"); 

System.Console.WriteLine();

// число фибаначе

// f(1)=1
// f(2)=1
// f(n)= f(n-1) + f(n-2)

double Fibonaci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonaci(n-1) + Fibonaci(n-2);
}
for (int i=1; i<40; i++)
{
    System.Console.WriteLine(Fibonaci(i));
}
System.Console.WriteLine();
for (int i=1; i<40; i++)
{
 System.Console.WriteLine(($"f{i}! ={Factorial(i)}"));
}
    