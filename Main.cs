using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string s = Console.ReadLine();

        int HexaNum = int.Parse(s), minMoveCnt = 1;

        
        while (HexaNum > 1)
        {
            HexaNum -= minMoveCnt * 6;

            minMoveCnt++;
        }
        

        Console.WriteLine(minMoveCnt);

    }

}
