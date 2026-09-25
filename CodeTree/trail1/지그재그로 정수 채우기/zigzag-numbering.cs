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
        int cnt = 0;
        for(int i = 0; i < M; i++)
        {
            if(i % 2 == 0)
            {
                for(int j = 0; j < N; j++)
                {
                    arr2d[j,i] = cnt;
                    cnt++;
                }
            }
            else
            {
                for(int j = N-1; j >= 0; j--)
                {
                    arr2d[j,i] = cnt;
                    cnt++;
                }
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
