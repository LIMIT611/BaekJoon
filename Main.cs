using System;
using System.Text;


class BaekJun
{

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine());

        StringBuilder output = new StringBuilder();

        StringBuilder rightAlign = new StringBuilder();


        for (int i = 1; i < N; i++)
        {
                
            rightAlign.Append(" ");

        }

        for (int i = 0; i < N; i++)
        {
                
            output.Append("*");
                
            Console.WriteLine($"{rightAlign}{output}");
                
            if (rightAlign.Length != 0)
            {
                    
                rightAlign.Remove(0, 1);

            }

        }

    }

}
