using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int[,] arr2d1 = new int[N,M];
        int[,] arr2d2 = new int[N,M];

        for(int i = 0; i < N; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int j = 0; j < M; j++)
            {
                arr2d1[i,j] = arr[j];
            }
        }

        for(int i = 0; i < N; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int j = 0; j < M; j++)
            {
                arr2d2[i,j] = arr[j];
            }
        }

        int[,] ansarr2d = new int[N,M];

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < M; j++)
            {
                if(arr2d1[i,j] == arr2d2[i,j])
                    ansarr2d[i,j] = 0;
                else
                    ansarr2d[i,j] = 1;
            }
        }

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < M; j++)
            {
                Console.Write($"{ansarr2d[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
