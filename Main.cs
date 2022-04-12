using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int[] length = new int[3];
        string[] s = new string[3];

        while (true)
        {
            s = Console.ReadLine().Split();
            
            if (s[0] == "0" && s[1] == "0" && s[2] == "0") break;

            length[0] = int.Parse(s[0]);
            length[1] = int.Parse(s[1]);
            length[2] = int.Parse(s[2]);

            Array.Sort(length);

            if (length[2] * length[2] == length[0] * length[0] + length[1] * length[1]) Console.WriteLine("right");
            else Console.WriteLine("wrong");
        }

    }

}
