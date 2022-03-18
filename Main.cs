using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] input = Console.ReadLine().Split();

        int H = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        if (H == 0 && M < 45) { H += 24; }    
        if (M < 45) { H -= 1; M += 60; }

        M -= 45;

        Console.WriteLine("{0} {1}", H, M);

    }

}
