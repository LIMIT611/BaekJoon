using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] s = Console.ReadLine().Split();
        string[] cardNums_input = Console.ReadLine().Split();
        
        int N = int.Parse(s[0]), M = int.Parse(s[1]);
        int closeSum, sum;
        int[] cardNums = new int[N];
        
        for (int i = 0; i < N; i++) cardNums[i] = int.Parse(cardNums_input[i]);
        
        closeSum = cardNums[0] + cardNums[1] + cardNums[2];

        for (int i = 0; i < N - 2; i++)
        {
            for (int j = i + 1; j < N - 1; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    sum = cardNums[i] + cardNums[j] + cardNums[k];
                    
                    if (Math.Abs(M - sum) < Math.Abs(M - closeSum) && sum <= M) closeSum = sum;
                }
            }
        }

        Console.WriteLine(closeSum);

    }

}
