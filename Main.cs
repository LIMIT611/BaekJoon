using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int numOfSubject = int.Parse(Console.ReadLine());
        string[] scoreOfsubjectInp = new string[numOfSubject];
        double[] scoreOfsubject = new double[numOfSubject];

        scoreOfsubjectInp = Console.ReadLine().Split();
        
        for (int i = 0; i < numOfSubject; i++)
        {

            scoreOfsubject[i] = double.Parse(scoreOfsubjectInp[i]);

        }

        Array.Sort(scoreOfsubject);

        double maxOfScore = scoreOfsubject[numOfSubject - 1];
        double sumOfscore = 0;

        for (int i = 0; i < numOfSubject; i++)
        {

            scoreOfsubject[i] = scoreOfsubject[i] / maxOfScore * 100;
                
            sumOfscore += scoreOfsubject[i];
                
        }
            
        Console.WriteLine(sumOfscore / numOfSubject);

    }

}
