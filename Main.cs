using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine());

        string[] input = Console.ReadLine().Split();

        int[] num = new int[N];

        for (int i = 0; i < N; i++) {

            num[i] = int.Parse(input[i]);

        }

        Array.Sort(num);
            
        Console.WriteLine($"{num[0]} {num[N-1]}");

        /*  Another Solution
            
            string input = Console.ReadLine();

            int N = int.Parse(input);

            string[] arrayInput = Console.ReadLine().Split();

            int[] num = new int[N];

            for (int i = 0; i < N; i++) {

                num[i] = int.Parse(arrayInput[i]);

            }

            int max = num[0]; int min = num[0];

            for (int i = 1; i < N; i++) {

                if (num[i] > max) max = num[i];

                if (num[i] < min) min = num[i];

            }
            
            Console.WriteLine($"{min} {max}");

        */

    }

}