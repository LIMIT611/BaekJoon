using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int n, count;
        bool[] isPrime = new bool[246913];

        isPrime[0] = false; isPrime[1] = false;
        for (int i = 2; i < 246913; i++) isPrime[i] = true;

        for (int i = 2; i <= 246912; i++)
        {
            if (isPrime[i] == true)
            {
                for (int j = 2; j * i <= 246912; j++) isPrime[j * i] = false;
            }
        }


        while (true)
        {
            count = 0;
            n = int.Parse(Console.ReadLine());

            if (n == 0) break;

            for (int i = n + 1; i <= 2 * n; i++)
            {
                if (isPrime[i] == true) count++;
            }

            Console.WriteLine(count);
        }

    }

}
