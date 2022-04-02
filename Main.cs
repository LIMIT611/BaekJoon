using System.Numerics;


class BaekJun
{

    public static void Main(String[] args)
    {

        string[] s = Console.ReadLine().Split('+');

        BigInteger A = BigInteger.Parse(s[0]), B = BigInteger.Parse(s[1]);
        
        Console.WriteLine(A + B);

    }

}
