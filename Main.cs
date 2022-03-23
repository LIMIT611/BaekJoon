using System;
using System.Text;


class BaekJun
{

    public static void Main(String[] args)
    {

        String[] s = Console.ReadLine().Split();
        StringBuilder reversedNum = new StringBuilder();

        int[] reversedNums = new int[] {0, 0};


        for(int i = 0; i < 2; i++)
        {

            for(int j = s[i].Length - 1; j >= 0; j--)
            {

                reversedNum.Append(s[i][j]);

            }

            reversedNums[i] = int.Parse(reversedNum.ToString());

            reversedNum.Clear();

        }


        if (reversedNums[0] > reversedNums[1]) Console.WriteLine(reversedNums[0]);
        else Console.WriteLine(reversedNums[1]);

    }

}

/* 

using System;
using System.Runtime;


class BaekJun
{

    public static void Main(String[] args)
    {

        String[] s = Console.ReadLine().Split();

        int[] reversedNum = new int[] {0, 0};


        for(int i = 0; i < 2; i++)
        {

            for (int j = s[i].Length - 1; j >= 0; j--)
            {
                
                reversedNum[i] += ((int)s[i][j]- 48) * ((int)Math.Pow(10, j));

            }

        }


        if (reversedNum[0] > reversedNum[1]) Console.WriteLine(reversedNum[0]);
        else Console.WriteLine(reversedNum[1]);

    }

}

*/
