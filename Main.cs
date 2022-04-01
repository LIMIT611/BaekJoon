using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine()), count = 0;
        

        while (N > 0)
        {
            if (N % 5 == 0)
            {
                N -= 5;

                count++;
            }

            else if (N % 3 == 0)
            {
                N -= 3;

                count++;
            }

            else if (N > 5)
            {
                N -= 5;

                count++;
            }

            else
            {
                count = -1;

                break;
            }
        }


        Console.WriteLine(count);

    }

}
