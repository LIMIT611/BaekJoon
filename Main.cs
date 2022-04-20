using System.Text;


class BaekJun
{
    
    struct BodyInfo
    {
        public int weight {get; set;}
        public int height {get; set;}
    }

    public static void Main(String[] args)
    {

        int testCase = int.Parse(Console.ReadLine()), count;
        BodyInfo[] bodyInfo = new BodyInfo[testCase];
        String[] s = new string[2];
        StringBuilder bulkDegree = new StringBuilder();

        for (int i = 0; i < testCase; i++)
        {
            s = Console.ReadLine().Split();
            
            bodyInfo[i].weight = int.Parse(s[0]);
            bodyInfo[i].height = int.Parse(s[1]);
        }
        
        for (int i = 0; i < testCase; i++)
        {
            count = 0;

            for (int j = 0; j < testCase; j++)
            {
                if (bodyInfo[i].weight < bodyInfo[j].weight && bodyInfo[i].height < bodyInfo[j].height) count++;
            }

            bulkDegree.Append($"{count + 1} ");
        }

        Console.WriteLine(bulkDegree);

    }

}
