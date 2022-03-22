using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        String s = Console.ReadLine();

        int[] alphabetCount = new int[26];
        int temp = 0;
        bool isOverlap = false;

        for (int i = 0; i < 26; i++) alphabetCount[i] = 0;

        for (int i = 0; i < s.Length; i++)
        {

            if ((int)s[i] < 97) temp = (int)s[i] - 65;
            else temp = (int)s[i] - 97;

            alphabetCount[temp] += 1; 

        }


        temp = 0;

        for (int i = 0; i < 26; i++) if (alphabetCount[i] > alphabetCount[temp]) temp = i;
        for (int i = 0; i < 26; i++) if (alphabetCount[i] == alphabetCount[temp] && temp != i) isOverlap = true;

        if (isOverlap != true) Console.WriteLine((char)(temp + 65));
        else Console.WriteLine("?");

    }

}
