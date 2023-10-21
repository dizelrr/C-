// цикл таблица умножения

for (int i = 2 ; i <=10 ; i++ )
    {
        for (int j = 2; j <=10;  j++ )
        {
        System.Console.WriteLine(($"{i} x {j} = {i * j}"));
        }
        System.Console.WriteLine(); // искуственный разрыв между строк
    }