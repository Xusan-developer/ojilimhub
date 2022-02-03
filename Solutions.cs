
public static class Solutions
{
    public static void Problem21()
    {
        var lenght = double.Parse(Console.ReadLine());
        var P = 3.14;

        var radius = lenght/(2*P);
        var S = P*radius*radius;

        Console.WriteLine(Math.Round(S));
    }
    public static void Problem22()
    {
        var son = int.Parse(Console.ReadLine());

        if(son >= 20 && son <= 30)
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
    }

    public static void Problem23()
    {
        var harf = char.Parse(Console.ReadLine());

        if(char.IsLetter(harf))
        {
            Console.WriteLine('1');
        }
        else
        {
            Console.WriteLine('0');
        }
    }
    public static void Problem24()
    {
        var son = int.Parse(Console.ReadLine());
        
        if( son % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
    public static void Problem25()
    {
        var son = Console.ReadLine()
            .Split( ' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        if( son[0] > son[1])
        {
            Console.WriteLine(son[0]);
        }
        else
        {
            Console.WriteLine(son[1]);
        }
    }
    public static void Problem26()
    {
        var son = Console.ReadLine()
            .Split( ' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        if( son[0] > son[1])
        {
            Console.WriteLine($"{son[0] / son[1]}");
            Console.WriteLine($"{son[0] % son[1]}");
        }
        else if (son[1] > son[0])
        {
            Console.WriteLine($"{son[1] / son[0]}");
            Console.WriteLine($"{son[1] % son[0]}");
        }
    }
    public static void Problem27()
    {

    }
    public static void Problem28()
    {
        var s =int.Parse( Console.ReadLine() );
        
        if( s < 0 || s >= 40)
        {
            Console.WriteLine("ichkarida o'yna");
        }
        else if ( s >= 0 || s < 40)
        {
            Console.WriteLine("tashqarida o'yna");
        }
    
    }
    public static void Problem29()
    {
        var son = Console.ReadLine()
            .Split( ' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        if( son[0] == son[1] * son[1] )
        {
            Console.WriteLine($"{son[1]}*{son[1]}={son[0]}");
        }
        else if( son[1] == son[0] * son[0] )
        {
            Console.WriteLine($"{son[0]}*{son[0]}={son[1]}");
        }
        else
        {
            Console.WriteLine("none");
        }
    }
    public static void Problem30()
    {
        var son = Console.ReadLine()
            .Split( ' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        if( son[0] >= son[1] && son[0] >= son[2] )
        {
            Console.WriteLine(son[0]);
        }
        else if( son[1] >= son[0] && son[1] >= son[2])
        {
            Console.WriteLine(son[1]);
        }
        else
        {
            Console.WriteLine(son[2]);
        }
    }
    public static void Problem31()
    {
        var son = int.Parse(Console.ReadLine());

        if( son % 2 == 0 && son % 3 == 0 && son % 5 == 0)
        {
            Console.WriteLine('A');
        }
        else if( son % 2 == 0 && son % 3 == 0)
        {
            Console.WriteLine('B');
        }
        else if( son % 2 == 0 && son % 5 == 0)
        {
            Console.WriteLine('C');
        }
        else if( son % 3 == 0 && son % 5 == 0)
        {
            Console.WriteLine('E');
            
        }
        else if( son % 2 == 0 || son % 3 == 0 || son % 5 == 0)
        {
            Console.WriteLine('D');
        }
        else
        {
            Console.WriteLine('N');
        }

    }
    public static void Problem32()
    {
        var year = int.Parse(Console.ReadLine());

        if( year % 4 == 0)
        {            
            if( year % 100 == 0)
            {
                if(year % 400 == 0)
                {
                    Console.WriteLine("Leap year");
                }
                else
                {
                    Console.WriteLine("Normal year");
                }
            }
            else
            {
                Console.WriteLine("Leap year");
            }

        }
        else
        {
            Console.WriteLine("Normal year");
        }
    }
    public static void Problem33()
    {
        var answer = int.Parse(Console.ReadLine());

        for( int i = 1; i <= 3; i++)
        {
            var guess = int.Parse(Console.ReadLine());
            if (guess > answer)
            {
                Console.WriteLine("Pastga");
            }
            else if(guess < answer)
            {
                Console.WriteLine("Teppaga");
            }
            else
            {
                Console.WriteLine("Yorvordiz");
            }
        }
    }
    public static void Problem34()
    {
        var harf = char.Parse(Console.ReadLine());
        if( harf >= 'a' && harf <= 'z')
        {
            Console.WriteLine(char.ToUpper(harf));
        }
        else if ( harf >= 'A' && harf <= 'Z')
        {
            Console.WriteLine(char.ToLower(harf));
        }
        else
        {
            Console.WriteLine("none");
        }
    }
}