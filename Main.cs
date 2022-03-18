using System;
using System.Text;


class BaekJun
{

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine());

        StringBuilder output = new StringBuilder();

        for (int i = 1; i < N + 1; i++) {
                
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            output.AppendLine($"Case #{i}: {A} + {B} = {A + B}");

        }

        Console.WriteLine(output);

    }

}
