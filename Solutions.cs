
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
}