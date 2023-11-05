// напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int number(string message) // метод ввода числа(значений)
{
System.Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int Coef = 0 ; // коэффициент прямой
int Cons = 1 ; // константа прямой
int x = 0 ;
int y = 1 ;
int line1 = 1 ;
int line2 = 2 ;

double [] InputLineData (int numOfLine) //  метод вводим данные прямой 
{
    double [] lineData = new double[2];
    lineData [Coef] = number($"введите коффициент для {numOfLine} прямой ");
    lineData [Cons] = number($"введите константу для {numOfLine} прямой ");
    return lineData;
}

double [] FindCoords (double[] lineData1, double [] lineData2) //метод поиска координат  
{
    double[] coord = new double[2];
    coord[x] = (lineData1[Cons] - lineData2[Cons]) / (lineData1[Coef] - lineData2[Coef]);
    coord[y] = lineData1[Cons] * coord[x] + lineData1[Cons];
    return coord;

}

bool ValidateLines (double [] lineData1 , double[] lineData2)
{
    if (lineData1[Coef] == lineData2[Coef])
        {
            if (lineData1[Cons] == lineData2[Cons])
            {
                System.Console.WriteLine("прямые совпадают");
                return false;
            }
            else
            {
                System.Console.WriteLine("прямые паралельны");
                return false;
            }
        }
        return true;

}


