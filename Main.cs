using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int[] numsArray = new int[9];

        for (int i = 0; i < 9; i++)
        {

            numsArray[i] = int.Parse(Console.ReadLine());

        }

        int maxValue = numsArray[0]; int numLocate = 1;

        for (int i = 1; i < 9; i++)
        {

            if (numsArray[i] > maxValue)
            {
                
                maxValue = numsArray[i];

                numLocate = i + 1;

            }
                
        }

        Console.WriteLine($"{maxValue}\n{numLocate}");

    }

}
