using System.Runtime;


class BaekJun
{

    public static void Main(String[] args)
    {

        double r = int.Parse(Console.ReadLine());

        Console.WriteLine("{0:F6}", r * r * Math.PI);
        Console.WriteLine("{0:F6}", r * r * 2);

    }

}
