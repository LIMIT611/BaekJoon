using System;


class BaekJun
{

    public static void Main(String[] args)
    {
    
        string input = Console.ReadLine();

        int N = int.Parse(input);

        int count = 1, num = 0;

        num = ((N / 10) + (N % 10)) % 10 + 10 * (N % 10);

        while (num != N) {

            num = ((num / 10) + (num % 10)) % 10 + 10 * (num % 10);

            count++;

        }

        Console.WriteLine(count);

    }

}
