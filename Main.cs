using System.Text;


class BaekJun
{

    public static void Main(String[] args)
    {

        int N = int.Parse(Console.ReadLine());

        StringBuilder primeFactor = new StringBuilder();

        
        for (int i = 2; i * i <= N; i++)
        {
            while (N % i == 0)
            {
                primeFactor.Append($"{i}\n");

                N /= i;
            }
        }

        if (N > 1) Console.WriteLine(primeFactor + $"{N}");
        
        else Console.Write(primeFactor);

    }

}


/* 

while (N > 1)
{
    if (N % primeNum == 0)
    {
        primeFactor.Append($"{primeNum}\n");
                
        N /= primeNum;
    }

    else
    {
        while (isPrime == false)
        {
            primeNum++;
            isPrime = true;
                
            for (int i = 2; i * i <= primeNum; i++)
            {
                if (primeNum % i == 0) isPrime = false;
            }
        }
    }

    isPrime = false;
}

 */