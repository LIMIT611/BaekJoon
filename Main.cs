using System.Collections;
using System.Text;


class BaekJun
{

    static StringBuilder moveProcess = new StringBuilder();
    static int Count = 0;
    static void Hanoi(int n, int currentTower, int targetTower)
    {   
        if (n == 1)
        {
            moveProcess.Append($"{currentTower} {targetTower}\n");
            Count++;
        }
        else
        {
            Hanoi(n - 1, currentTower, 6 - currentTower - targetTower);
            Hanoi(1, currentTower, targetTower);
            Hanoi(n - 1, 6 - currentTower - targetTower, targetTower);
        }
    }

    public static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        Hanoi(N, 1, 3);

        Console.WriteLine(Count);
        Console.WriteLine(moveProcess);

    }

}
