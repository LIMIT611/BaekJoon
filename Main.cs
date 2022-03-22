using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        String s  = Console.ReadLine();

        bool isWord = false;

        int wordCnt = 0;


        for (int i = 0; i < s.Length; i++)
        {

            if ((int)s[i] != 32)
            {
                
                if (isWord == false) wordCnt++;

                isWord = true;

            }
            else if (isWord == true) isWord = false;

        }


        Console.WriteLine(wordCnt);

    }

}
