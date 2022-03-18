using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int testCase = int.Parse(Console.ReadLine());
            
            
        for (int i = 0; i < testCase; i++)
        {
                
            string[] input = Console.ReadLine().Split();
            int studentNum = int.Parse(input[0]);
            int[] inputNum = new int[studentNum + 1];
            float sum = 0, average = 0, count = 0;

            for (int j = 0; j < studentNum + 1; j++)
            {

                inputNum[j] = int.Parse(input[j]);

                if (j >= 1) sum += inputNum[j];
                
            }

            average = sum / (float)studentNum;

            for (int j = 0; j < studentNum + 1; j++)
            {

                if (j >= 1 && inputNum[j] > average) count++;

            }

            float result = count / (float)studentNum * 100;

            Console.WriteLine($"{result:F3}%");

        } 

    }

}
