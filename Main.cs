using System;
using System.Text;

class BaekJun
{

    static void StringRepeat()
    {

        String[] s = Console.ReadLine().Split();
        
        StringBuilder p = new StringBuilder();

        for(int i = 0; i < s[1].Length; i++)
        {

            for (int j = 0; j < int.Parse(s[0]); j++) p.Append(s[1][i]);

        }

        Console.WriteLine(p);

    }


    public static void Main(String[] args)
    {

        String T = Console.ReadLine();

        for (int i = 0; i < int.Parse(T); i++) StringRepeat();

    }

}
