using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
            
        int a = B % 10;
        int b = B % 100 / 10;
        int c = B % 1000 / 100;

        Console.WriteLine(a * A);
        Console.WriteLine(b * A);
        Console.WriteLine(c * A);
        Console.WriteLine(A * B); 

    }

}
