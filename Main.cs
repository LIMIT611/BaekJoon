using System;


class BaekJun
{
    
    public static void Main(String[] args)
    {

        String[] s = Console.ReadLine().Split();

        long fixedCost = int.Parse(s[0]), variableCost = int.Parse(s[1]), saleCost = int.Parse(s[2]);
        long salesCnt = 0;

        bool isBreakEvenPoint = false;

        if (variableCost < saleCost)
        {
            while (isBreakEvenPoint == false)
            {
                salesCnt++;
                
                if (fixedCost + variableCost * salesCnt < saleCost * salesCnt) isBreakEvenPoint = true;
            }
        }

        else salesCnt = -1;


        Console.WriteLine(salesCnt);

    }

}
