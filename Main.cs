using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        String[] s = Console.ReadLine().Split();
        int H = 0, M = 0, time = 0;

        H = int.Parse(s[0]);
        M = int.Parse(s[1]);


        s[0] = Console.ReadLine();

        time = int.Parse(s[0]);


        M += time;

        loop:

        if (M >= 60) {H += 1; M -= 60; goto loop;}
        if (H >= 24) {H -= 24; goto loop;}
        

        Console.WriteLine($"{H} {M}");

    }

}
