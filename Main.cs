using System;


class BaekJun
{

    static int SumOfSplitNum(int n)
    {
        int result = n;
        
        while (n > 0)
        {
            result += n % 10;

            n /= 10;
        }

        return result;
    }

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine());
        int constructorMin = 0;

        for (int i = 1; i < N; i++)
        {
            if (SumOfSplitNum(i) == N)
            {
                constructorMin = i;
                break;
            }
        }

        Console.WriteLine(constructorMin);
    }

}
