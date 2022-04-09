using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int testCase = int.Parse(Console.ReadLine()), N, maxPrime = 2;
        bool[] isPrime = new bool[10001];

        for (int i = 2; i <= 10000; i++) isPrime[i] = true;

        for (int i = 2; i <= 10000; i++)
        {
            if (isPrime[i] == true)
            {
                for (int j = 2; j * i <= 10000; j++) isPrime[j * i] = false;
            }
        }

        while (testCase > 0)
        {
            N = int.Parse(Console.ReadLine());
            
            for (int i = 2; i <= N / 2; i++)
            {
                if (isPrime[i] && isPrime[N - i]) maxPrime = i;
            }

            Console.WriteLine($"{maxPrime} {N - maxPrime}");

            testCase--;
        }

    }

}
