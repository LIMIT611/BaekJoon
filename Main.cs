using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine()), sum = 0;
        String eachOfDigit = Console.ReadLine();

        for (int i = 0; i < eachOfDigit.Length; i++)
        {

            sum += int.Parse(eachOfDigit[i].ToString());

        }

        Console.WriteLine(sum);

    }

}
