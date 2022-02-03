
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
}