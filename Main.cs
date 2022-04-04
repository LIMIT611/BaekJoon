using System;


class BaekJun
{

    public static void Main(String[] args)
    {
        
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int temp, sum = 0, min = 0;

        bool isPrime = true;


        for (int i = M; i <= N; i++)
        {
            temp = 2;
            isPrime = true;

            if (i == 1) isPrime = false;

            while (temp * temp <= i)
            {
                if (i % temp == 0) isPrime = false;

                temp++;
            }

            if (isPrime == true)
            {
                sum += i;
                
                if (min == 0) min = i;
            }
        }

        
        if (sum != 0) Console.WriteLine($"{sum}\n{min}");
        
        else Console.WriteLine(-1);

    }

}
