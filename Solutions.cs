
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
    public static void Problem27()   // ishlanmadi
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
    public static void Problem35()   //ishlanmadi
    {
        var guess1 = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        var guess2 = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        var s = 0;
        var b = 0;
        for(int i = 0; i<=2; i++)
        {
            if(guess1[i]==guess2[i])
            {
                s++;
            }
        }
        Console.Write($"{s}S");
        for(int k = 0; k<=2; k++)
        {
            for(int y = 0; y<=2; y++)
            {
                if( guess1[k] == guess2[y] )
                {
                    s++;
                }
                else{b++;}
            }
        }
        Console.WriteLine($"{b}B");
    }
    public static void Problem36()  //ishlanmadi
    {

    }
    public static void Problem37()
    {
        Console.WriteLine("1.Americano (500 sum)");
        Console.WriteLine("2.Caffe Latte (400 sum)");
        Console.WriteLine("3.Lemon Tea (300 sum)");

        var num = int.Parse(Console.ReadLine());
        var sum = int.Parse(Console.ReadLine());
        var result = 0;

        var Americano =500;
        var Caffe = 400;
        var Lemon = 300;
        switch(num)
        {
            case 1: 
                result = sum-Americano;
                Console.WriteLine("Americano");
                Console.WriteLine($"{result/500} {result%500/100}");
                break;
            case 2:
                result = sum-Caffe;
                Console.WriteLine("Caffe Latte");
                Console.WriteLine($"{result/500} {result%500/100}");
                break;
            case 3:
                result = sum-Lemon;
                Console.WriteLine("Lemon Tea");
                Console.WriteLine($"{result/500} {result%500/100}");
                break;
        }
    }
    public static void Problem38()   //ishlanmadi
    {
        var pif = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        if(pif[0]>pif[1]&&pif[0]>pif[2])
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
    public static void Problem39()  //ishlanmadi chala
    {
        var son = int.Parse(Console.ReadLine());
        var sonlar = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        var cube = 0;
        var count = 0;
        for( int i = 1; i <= son; i++ )
        {
            cube = sonlar[i-1]*sonlar[i-1]*sonlar[i-1];
            count+=cube;
        }
        Console.WriteLine(count);
    }
    public static void Problem40()
    {
        var num = long.Parse(Console.ReadLine());
        int fac = 1;

        for(int i = 1; i<=num; i++)
        {
            fac*=i;
            if(fac==num)
            {
                Console.WriteLine("true");
                break;
            }
        }  
        if(fac!=num)
        {
            Console.WriteLine("false");
        }
    }
    public static void Problem41()
    {
        var son = int.Parse(Console.ReadLine());

        for(int i = 2; i < son; i++)
        {
            if(son % i == 0)
            {
                son++;
                i = 2;
            }
            else
            {
                Console.WriteLine(son);
                break;
            }
        }
    }
    public static void Problem42()  //ishlanmadi
    {
        var son = int.Parse(Console.ReadLine());
        var sonlar = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        Console.WriteLine($"{sonlar}");
    }
    public static void Problem43()
    {
        var sonlar = Console.ReadLine()
			.Split(' ', StringSplitOptions.RemoveEmptyEntries)
			.Select(long.Parse)
			.ToList();
		
		int count = 0;
		long a = sonlar[0];
		long b = sonlar[1];

		while(a > 1 && b > 1)
		{
			a = a % 2 == 0 ? a / 2 : a * 3 + 1;
			b = b % 2 == 0 ? b / 2 : b * 3 + 1;
			count++;
		}

		    Console.WriteLine($"{(a == 1 ? sonlar[0] : sonlar[1])} {count}");
    }
}