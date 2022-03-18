using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int maxCount = 10;
        int divNum = 42;
        int count = 0;
        int[] remainder = new int[maxCount];

        for (int i = 0; i < maxCount; i ++)
        {

            remainder[i] = int.Parse(Console.ReadLine()) % divNum;

        }

        bool[] isRemain = new bool[divNum];

        for (int i = 0; i < maxCount; i ++)
        {

            for (int j = 0; j < divNum; j ++)
            {
                    
                if (remainder[i] == j)
                {
                        
                    isRemain[j] = true;

                }

            }

        }

        for (int i = 0; i < isRemain.Length; i ++)
        {

            if (isRemain[i]) count++;

        }

        Console.WriteLine(count);

    }

}
