using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string s = Console.ReadLine();
        int[] alphbtLocate = new int[26];

        for (int i = 0; i < 26; i++)
        {

            alphbtLocate[i] = -1;
            
        }

        for (int i = 0; i < 26; i++)
        {

            for (int j = 0; j < s.Length; j++)
            {

                if ((char)(i + 97) == s[j])
                {

                    alphbtLocate[i] = j;
                    break;

                }

            }

        }

        for (int i = 0; i < 26; i++)
        {

            Console.Write($"{alphbtLocate[i]} ");

        }

    }

}
