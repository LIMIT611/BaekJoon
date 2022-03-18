using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string input = Console.ReadLine();

        int n = int.Parse(input);

        for (int i = 1; i < 10; i++)
        {

            Console.WriteLine($"{n} * {i} = {n * i}");

        }

    }

}
