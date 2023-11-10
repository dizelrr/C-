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

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines(lineData1,lineData2))
{
    double[] coord = FindCoords(lineData1,lineData2);
    System.Console.WriteLine($"Точка пересечения уравнений y={lineData1[Coef]}*x+{lineData1[Cons]} и y={lineData2[Coef]}*x+{lineData2[Cons]} ");
    System.Console.WriteLine($"имееь координаты ({coord[x]}, {coord[y]})");
}


double [] InputLineData (int numOfLine)//  метод вводим данные прямой 
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

bool ValidateLines (double [] lineData1 , double[] lineData2) // метод проверяем  линии на пересечение
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


