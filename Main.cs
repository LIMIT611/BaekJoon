using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] input = Console.ReadLine().Split();

        int N = int.Parse(input[0]);
        int X = int.Parse(input[1]);

        input = Console.ReadLine().Split();

        for (int i = 0; i < N; i++) {
                
            int[] A = new int[N];
            A[i] = int.Parse(input[i]);

            if (A[i] < X) Console.Write($"{A[i]} ");

        }

    }

}
