using System;


class BaekJun
{

    public static int Factorial(int n)
    {
        int result = 1;

        if (n != 0) result *= n * Factorial(n - 1);
        
        return result;
    }

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine());

        Console.WriteLine(Factorial(N));

    }

}
