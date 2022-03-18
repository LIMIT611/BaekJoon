using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] input = Console.ReadLine().Split();

        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);
            
        Console.WriteLine((A + B) % C);
        Console.WriteLine(((A % C) + (B % C)) % C);
        Console.WriteLine((A * B) % C);
        Console.WriteLine(((A % C) * (B % C)) % C); 

    }

}
