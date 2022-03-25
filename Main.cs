using System;
using System.Text;


class BaekJun
{

    public static void Main(String[] args)
    {

        String s = Console.ReadLine();
        StringBuilder cutWord = new StringBuilder();

        int wordCnt = 0;


        for (int i = 0; i < s.Length; i++)  // 배열에 문자 담기 + 크로아티아 문자 나오면 개수 카운팅
        {
            if (cutWord.Length > 1)
            {
                if (cutWord[cutWord.Length - 1] == '=' || cutWord[cutWord.Length - 1] == '-' || cutWord[cutWord.Length - 1] == 'j')
                {
                    wordCnt += WordCount(cutWord);
                    cutWord.Clear();
                }
            }

            cutWord.Append(s[i]);
        }

        if (cutWord.Length > 0) wordCnt += WordCount(cutWord);  // 걸러지지 않은 문자들 처리

        
        Console.WriteLine(wordCnt);

    }


    static int WordCount(StringBuilder sb)  // 크로아티아 + 알파벳의 단어 개수 측정
    {

        int count = 0;


        if (sb.Length < 2) // 문자열 길이가 2보다 작을 때
        {
            count = sb.Length;

            return count;
        }

        else if (sb.Length > 2)  // 문자열의 길이가 3 이상일 때 dz= 가능성 판별
        {
            if (sb[sb.Length - 1] == '=' && sb[sb.Length - 2] == 'z' && sb[sb.Length - 3] == 'd')
            {
                count = sb.Length - 2;
                
                return count;
            }
        }


        if (sb[sb.Length - 1] == '=' && (sb[sb.Length - 2] == 'c' || sb[sb.Length - 2] == 's' || sb[sb.Length - 2] == 'z') // 2글자 크로아티아 문자 가능성 판별
            || (sb[sb.Length - 1] == '-' && (sb[sb.Length - 2] == 'c' || sb[sb.Length - 2] == 'd'))
            || (sb[sb.Length - 1] == 'j' && (sb[sb.Length - 2] == 'l' || sb[sb.Length - 2] == 'n')))
        {
            count = sb.Length - 1;
            
            return count;
        }
        
        else    // 크로아티아 문자가 없을 때
        {
            count = sb.Length;

            return count;
        }

    }

}
