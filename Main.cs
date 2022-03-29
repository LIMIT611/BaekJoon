using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] s = Console.ReadLine().Split();

        int A = int.Parse(s[0]), B = int.Parse(s[1]), V = int.Parse(s[2]), dayCnt;
        
        
        dayCnt = (V - A)/ (A - B);

        while (A * dayCnt - B * (dayCnt - 1) < V) dayCnt++;


        Console.WriteLine(dayCnt);
    }

}
