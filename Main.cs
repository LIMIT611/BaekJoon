using System;


class BaekJun
{

    static int SumOfEachDigit(int n)
    {
        
        int result = n, temp = n;

        while (temp >= 10)
        {

            result += temp % 10; 

            temp /= 10;

        }

        result += temp;

        return result;

    }

    public static void Main(String[] args)
    {

        int[] NumsArray = new int[10000];

        
        for (int i = 0; i < NumsArray.Length; i++)
        {

            NumsArray[i] = i + 1;

        }

        for (int i = 1; i <= NumsArray.Length; i++)
        {

            if(SumOfEachDigit(i) <= 10000) NumsArray[SumOfEachDigit(i) - 1] = 0;

        }

        for (int i = 0; i < NumsArray.Length; i++)
        {

            if(NumsArray[i] != 0) Console.WriteLine($"{NumsArray[i]}");

        }

    }

}
