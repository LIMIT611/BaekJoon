using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] s = Console.ReadLine().Split();
        
        int x = int.Parse(s[0]), y = int.Parse(s[1]), w = int.Parse(s[2]), h = int.Parse(s[3]);

        int minX = x, minY = y;
        
        if (x > w - x) minX = w - x;
        if (y > h - y) minY = h - y;
        
        if (minX < minY) Console.WriteLine(minX);
        else Console.WriteLine(minY);

    }

}
