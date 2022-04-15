using System;


class BaekJun
{

    static int Fibonacci(int n)
    {
        int result = 0;
        
        if (n >= 2) result = Fibonacci(n - 1) + Fibonacci (n - 2);
        if (n < 2) result = n;

        return result;
    }

    public static void Main(String[] args)
    {

        Console.WriteLine(Fibonacci(int.Parse(Console.ReadLine())));

    }

}
