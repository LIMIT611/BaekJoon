using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int[] xList = new int[3], yList = new int[3];
        int x, y;
        string[] s = new string[2];

        for (int i = 0; i < 3; i++)
        {
            s = Console.ReadLine().Split();
            
            xList[i] = int.Parse(s[0]);
            yList[i] = int.Parse(s[1]);
        }

        Array.Sort(xList);
        Array.Sort(yList);

        if (xList[0] == xList[1]) x = xList[2];
        else x = xList[0];

        if (yList[0] == yList[1]) y = yList[2];
        else y = yList[0];

        Console.WriteLine($"{x} {y}");

    }

}
