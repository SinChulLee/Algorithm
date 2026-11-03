using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        int[] blocks = new int[N];
        for(int i = 0; i < K; i++)
        {
            string[] input2 = Console.ReadLine().Split();
            int A = int.Parse(input2[0]);
            int B = int.Parse(input2[1]);

            for(int j = A-1; j <= B-1; j++)
                blocks[j]++;
        }

        int max = blocks[0];
        for(int k = 1; k < N; k++)
        {
            if(blocks[k] > max)
                max = blocks[k];
        }

        Console.Write(max);
    }
}
