using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] line = new int[101];
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x1 = int.Parse(input[0]);
            int x2 = int.Parse(input[1]);
            for(int j = x1; j <= x2; j++)
            {
                line[j]++;
            }
        }

        int max = line[0];
        for(int k = 0; k < 101; k++)
        {
            if(line[k] > max)
                max = line[k];
        }

        Console.Write(max);
    }
}
