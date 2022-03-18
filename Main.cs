using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] input = new string[2];

        input[0] = Console.ReadLine();
        input[1] = Console.ReadLine();

        int X = int.Parse(input[0]);
        int Y = int.Parse(input[1]);

        if (X > 0) {
                
            if (Y > 0) { Console.WriteLine("1"); }
            if (Y < 0) { Console.WriteLine("4"); }

        }
            
        if (X < 0) {

            if (Y > 0) { Console.WriteLine("2"); }
            if (Y < 0) { Console.WriteLine("3"); }

        }
        
    }

}
