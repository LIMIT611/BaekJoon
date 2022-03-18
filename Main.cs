using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int sum = 0, count = 0;
        int n = int.Parse(Console.ReadLine());
        string str;

        for (int i = 0; i < n; i++)
        {

            str = Console.ReadLine();

            foreach (char c in str)
            {

                if (c == 'O')
                {

                    count++;
                    sum += count;

                }
                else count = 0;

            }
                
            Console.WriteLine(sum);

            count = 0;
            sum = 0;
            
        }
    
    }

}
