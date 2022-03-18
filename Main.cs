using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string input;

        input = Console.ReadLine();

        int year = int.Parse(input);

        if (year % 4 == 0)
        {
                
            if (year % 100 != 0) Console.WriteLine("1");
                
            else if (year % 400 == 0) Console.WriteLine("1");

            else Console.WriteLine("0");

        }

        else Console.WriteLine("0");

    }

}
