using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        int numsMultiply = A * B * C;
        int[] numsCount = new int[10];

        while (numsMultiply > 0)
        {

            numsCount[numsMultiply % 10]++;

            numsMultiply /= 10;

        }

        for (int i = 0; i < 10; i++)
        {

            Console.WriteLine($"{numsCount[i]}");

        }

    }

}
