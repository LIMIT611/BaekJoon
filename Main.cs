using System;


class BaekJun
{

    public static void Main(String[] args)
    {
        
        string testCase = Console.ReadLine();
        string[] s = new string[3];
        int H, W, N, roomNum;

        for (int i = 0; i < int.Parse(testCase); i++)
        {
            s = Console.ReadLine().Split();

            H = int.Parse(s[0]);
            W = int.Parse(s[1]);
            N = int.Parse(s[2]);

            if (N % H == 0) roomNum = H * 100 + N / H;

            else roomNum = N % H * 100 + (N / H + 1);

            Console.WriteLine(roomNum);
        }

        

    }

}
