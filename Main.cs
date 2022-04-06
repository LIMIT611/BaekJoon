using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] s = Console.ReadLine().Split();
        int M = int.Parse(s[0]), N = int.Parse(s[1]);
        bool[] isPrime = new bool[N + 1];
        
        for (int i = 2; i < N + 1; i++) isPrime[i] = true;

        for (int i = 2; i < N + 1; i++)
        {
            if (isPrime[i] == true)
            {
                for (int j = 2 * i; j <= N; j += i) isPrime[j] = false;
            }
        }

        for (int i = M; i < N + 1; i++)
        {
            if (isPrime[i] == true) Console.WriteLine(i);
        }

    }

}
