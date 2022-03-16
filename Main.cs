using System;


class BaekJun
{
    static Boolean isArithm(int n)
    {
    
        List<int> eachOfDigit = new List<int>();
        int temp = n, diffOfNums = 0;
        bool discrimArithm = true;
        

        eachOfDigit.Add(temp % 10);

        while (temp >= 10)
        {

            temp /= 10;

            eachOfDigit.Add(temp % 10);

        }
        

        if (eachOfDigit.Count > 1)
        {

            diffOfNums = eachOfDigit[1] - eachOfDigit[0];

            for (int i = 1; i < eachOfDigit.Count; i++)
            {

                if (eachOfDigit[i] - eachOfDigit[i - 1] != diffOfNums) discrimArithm = false;

            } 

        }


        return discrimArithm;

    }


    public static void Main(String[] args)
    {

        List<int> ArithmNums = new List<int>();
        int N = 0;
        bool discrimArithm;
        String s = Console.ReadLine();

        N = int.Parse(s);


        for (int i = 1; i <= N; i++)
        {

            discrimArithm = isArithm(i);

            if (discrimArithm == true) ArithmNums.Add(i);

        }


        Console.WriteLine(ArithmNums.Count);

    }

}
