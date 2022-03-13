using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] input = new string[2];

        input = Console.ReadLine().Split();
            
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        if (A < B) { Console.WriteLine("<"); }
        else if (A == B) { Console.WriteLine("=="); }
        else { Console.WriteLine(">"); }

    }

}
