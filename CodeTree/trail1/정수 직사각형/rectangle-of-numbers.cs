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
        
        int sum = 1;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < M; j++)
            {
                arr2d[i,j] = sum;
                sum++;
            }
        }

        for(int h = 0; h < N; h++)
        {
            for(int k = 0; k < M; k++)
            {
                Console.Write($"{arr2d[h,k]} ");
            }
            Console.WriteLine();
        }
    }
}
