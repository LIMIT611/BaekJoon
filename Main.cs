using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        String s = Console.ReadLine();
        char[] capitals = s.ToCharArray();
        
        int sumOfTime = 2 * capitals.Length;

        
        for (int i = 0; i < capitals.Length; i++)
        {

            CapitalToNum(ref sumOfTime, capitals[i]);

        }

        
        Console.WriteLine(sumOfTime);

    }

    static void CapitalToNum(ref int addTime, char c)
    {

        if (c >= 'A' && c < 'D') addTime += 1;
        
        else if (c >= 'D' && c < 'G') addTime += 2;

        else if (c >= 'G' && c < 'J') addTime += 3;

        else if (c >= 'J' && c < 'M') addTime += 4;

        else if (c >= 'M' && c < 'P') addTime += 5;

        else if (c >= 'P' && c < 'T') addTime += 6;

        else if (c >= 'T' && c < 'W') addTime += 7;

        else if (c >= 'W' && c <= 'Z') addTime += 8;

    }

}
