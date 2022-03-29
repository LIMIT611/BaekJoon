using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string s = Console.ReadLine();
        
        int Cnt = 1, X = int.Parse(s);


        while (X > Cnt)
        {
            X -= Cnt;

            Cnt++;
        }
        

        if (Cnt % 2 == 0) Console.WriteLine($"{X}/{Cnt - X + 1}");

        else Console.WriteLine($"{Cnt - X + 1}/{X}");
        
    }

}
