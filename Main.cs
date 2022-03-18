using System;
using System.Text;


class BaekJun
{

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine());

        StringBuilder output = new StringBuilder();

        for (int i = 1; i < N + 1; i++)
        {
                
            output.AppendLine($"{i}");

        }

        Console.WriteLine(output);

    }

}
