using System;
using System.Text;


class BaekJun
{

    public static void Main(String[] args)
    {

        int T = int.Parse(Console.ReadLine());

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < T; i++) {
                
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            output.AppendLine($"{A + B}");

        }

        Console.WriteLine(output);

    }

}
