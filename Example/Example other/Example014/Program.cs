// Дан текст , работа с текстом , звмена пробелов в тексте

string text = "Привет мир как дела "
            + "нормально всё как всегда"
            + "пусть так будет всегда"
            + "и ничего не меняется";

string Replace (string text, char oldValue, char newValue) // метод замены одного на другое 
    {
        string result = String.Empty;

        int length = text.Length;
        for (int i = 0 ; i < length; i++ )
        {
            if (text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
        }
        return result;
    }

    string newText = Replace (text, ' ', '|');
    System.Console.WriteLine(newText);
    System.Console.WriteLine();
    newText = Replace (text, 'а', 'А');
    System.Console.WriteLine(newText);
    System.Console.WriteLine();
    newText = Replace (text, 'а', '!');
    System.Console.WriteLine(newText);