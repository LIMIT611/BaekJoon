using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string input = Console.ReadLine();

        int testScore = int.Parse(input);

        if (testScore >= 90) { Console.WriteLine("A"); }
        else if (testScore >= 80) { Console.WriteLine("B"); }
        else if (testScore >= 70) { Console.WriteLine("C"); }
        else if (testScore >= 60) { Console.WriteLine("D"); }
        else { Console.WriteLine("F"); }

    }

}
