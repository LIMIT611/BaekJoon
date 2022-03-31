using System;


class BaekJun
{

    public static void Main(String[] args)
    {

        int testCase = int.Parse(Console.ReadLine());
        int floor, roomNum;
        
        while (testCase > 0)
        {
            floor = int.Parse(Console.ReadLine());
            roomNum = int.Parse(Console.ReadLine());
            
            // Console.WriteLine(Combination(floor + roomNum, roomNum -1));
            Console.WriteLine(TwistedPascalTriangle(floor, roomNum));

            testCase--;
        }

    }


    /* static long Combination(long n, long r)
    {

        long result, factorial_n = 1, factorial_r = 1;

        
        for (long i = n; i > (n - r); i--) factorial_n *= i;
        for (long i = 1; i <= r; i++) factorial_r *= i;

        result = factorial_n / factorial_r;


        return result;

    } */


    static int TwistedPascalTriangle(int length, int width)
    {

        int result = 0;


        if (width > 1)
        {
            if (length > 0) result = TwistedPascalTriangle(length, width -1) + TwistedPascalTriangle(length - 1, width);

            else result = width;
        }

        else result = 1;


        return result;

    }
}
