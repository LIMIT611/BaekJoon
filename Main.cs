using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        while(true) {

            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
                
            if((A==0) && (B==0)) break;

            Console.WriteLine($"{A + B}");
            
        }

    }

}
