using System.Runtime;


class BaekJun
{
    
    public static void Main(string[] args)
    {
        
        int testCase = int.Parse(Console.ReadLine()), count = 0;
        string[] s = new string[6];

        int x1, y1, r1, x2, y2, r2, sub, sum;
        double d;

        while (testCase > 0)
        {
            s = Console.ReadLine().Split();

            x1 = int.Parse(s[0]);
            y1 = int.Parse(s[1]);
            r1 = int.Parse(s[2]);
            x2 = int.Parse(s[3]);
            y2 = int.Parse(s[4]);
            r2 = int.Parse(s[5]);

            d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            sub = Math.Abs(r1 - r2);
            sum = r1 + r2;

            if (x1 == x2 && y1 == y2 && r1 == r2) Console.WriteLine(-1);
            else if (d == sum) Console.WriteLine(1);
            else if (d == sub) Console.WriteLine(1);
            else if (d < sub) Console.WriteLine(0);
            else if (d > sum) Console.WriteLine(0);
            else Console.WriteLine(2);
            

            testCase--;
        }

    }

}
