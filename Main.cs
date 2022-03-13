using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] input = Console.ReadLine().Split();
            
        double output = double.Parse(input[0]) / double.Parse(input[1]);

        Console.WriteLine(output);

    }

}