using System;
using System.Text;


class BaekJun
{

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine());

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < N; i++) {
                
            for (int j = 0; j <= i; j++) {

                output.Append("*");

            }

               output.AppendLine();

        }

        Console.WriteLine(output);

    }

}
