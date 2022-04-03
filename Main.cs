using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int testCase = int.Parse(Console.ReadLine()), temp;

        string[] s = Console.ReadLine().Split();
        

        for (int i = 0; i < s.Length; i++)
        {
            temp = int.Parse(s[i]);

            if ((temp != 2 && temp % 2 == 0) || temp == 1) testCase--;

            else
            {
                for (int j = 3; j < temp; j += 2)
                {
                    if (temp % j == 0)
                    {
                        testCase--;
                        break;
                    }
                }
            }
        }

        
        Console.WriteLine(testCase);

    }

}
