using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        String s = Console.ReadLine();

        int testCase = int.Parse(s), groupWordCnt = 0;
        bool isGroupWord, isExist, isApart;


        while (testCase > 0)    // Test case 만큼 반복
        {
            s = Console.ReadLine();

            isGroupWord = true;
            isExist = false;
            isApart = false;

            for (int i = 97; i < 123; i++)  // 알파벳마다 그룹 단어 체크
            {
                for (int j = 0; j < s.Length; j++)  // 분리된 알파벳 존재 여부 확인
                {
                    if (s[j] == (char)i)
                    {
                        isExist = true;

                        if (isApart == true) isGroupWord = false;
                    }
                    
                    else if (isExist == true) isApart = true;
                }

                isExist = false;
                isApart = false;
            }

            if (isGroupWord == true) groupWordCnt++;

            testCase--;
        }
        

        Console.WriteLine(groupWordCnt);

    }

}
