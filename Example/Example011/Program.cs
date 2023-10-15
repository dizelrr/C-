// перывй вид методов которые не возращают
void Method1 () // метод войд 
    {
        System.Console.WriteLine("Автор ...");
    }
    Method1();




// второй вид метода который ничего не возвращает
void Method2 (string msg)
    {
        System.Console.WriteLine(msg);
    }
Method2("Текст сообщения");


void Method21 (string msg, int count) // метод с  указанием количества раз
    {
        int i = 0;
        while (i<count)
        {
        System.Console.WriteLine(msg);
        i++;
        }
    }
Method21("text",4);
Method21 ( count:4, msg: "text new");

//третий вид метода который возвращают но ничего не принимают
int Metod3()
    {
        return DateTime.Now.Year;
    }
int year = Metod3();
System.Console.WriteLine(year);


// четвертый виды методов которые и принимают и возвращают
string Method4 (int count, string text)
    {
        int i = 0 ;
        string result = String.Empty;

        while ( i < count)
        {
            result = result + text;
            i++;
        }
        return result;
    
    }

string res = Method4 ( 10, "z");
System.Console.WriteLine(res);