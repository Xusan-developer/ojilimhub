
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
}