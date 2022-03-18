using System;
using System.Text;


class BaekJun
{

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine());

        StringBuilder output = new StringBuilder();

        for (int i = N; i > 0; i--)
        {
                
            output.AppendLine($"{i}");

        }

        Console.WriteLine(output);

    }

}
