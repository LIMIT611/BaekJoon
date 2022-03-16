using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        String[] s = Console.ReadLine().Split();
        int providedMoney = 0;
        List<int> diceNums = new List<int>();

        diceNums.Add(int.Parse(s[0]));
        diceNums.Add(int.Parse(s[1]));
        diceNums.Add(int.Parse(s[2]));
        
        diceNums.Sort();

        if (s[0] == s[1] && s[1] == s[2] && s[2] == s[0]) providedMoney = 10000 + int.Parse(s[0]) * 1000;
        else if (s[0] == s[1]) providedMoney = 1000 + int.Parse(s[0]) * 100;
        else if (s[1] == s[2]) providedMoney = 1000 + int.Parse(s[1]) * 100;
        else if (s[2] == s[0]) providedMoney = 1000 + int.Parse(s[2]) * 100;
        else providedMoney = diceNums[2] * 100;


        Console.WriteLine(providedMoney);

    }

}
