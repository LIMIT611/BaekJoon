using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] input = Console.ReadLine().Split();
            
        int a = int.Parse(input[0]) + int.Parse(input[1]);
        int b = int.Parse(input[0]) - int.Parse(input[1]);
        int c = int.Parse(input[0]) * int.Parse(input[1]);
        int d = int.Parse(input[0]) / int.Parse(input[1]);
        int e = int.Parse(input[0]) - d * int.Parse(input[1]);

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", a, b, c, d, e);

    }

}
