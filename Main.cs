using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int T = int.Parse(Console.ReadLine());

        int[] output = new int[T];

        for (int i = 0; i < T; i++) {
                
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            output[i] = A + B;

        }

        for (int j = 0; j < T; j++) {

            Console.WriteLine(output[j]);

        }

    }

}
