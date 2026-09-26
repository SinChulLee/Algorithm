using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int[,] arr2d = new int[N,M];
        int cnt = 1;

        for(int i = 0; i < N+M-1; i++)
        {
            for(int j = 0; j < N; j++)
            {
                int s = i - j;
                if(s < 0 || s >= M)
                    continue;
                arr2d[j,i-j] = cnt;
                cnt++;
            }
        }

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < M; j++)
            {
                Console.Write($"{arr2d[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
