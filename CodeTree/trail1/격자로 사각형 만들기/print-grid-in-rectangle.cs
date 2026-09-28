using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[,] arr2d = new int[N,N];

        for(int i = 0; i < N; i++)
        {
            arr2d[i,0] = 1;
            arr2d[0,i] = 1;
        }

        for(int i = 1; i < N; i++)
        {
            for(int j = 1; j < N; j++)
            {
                arr2d[i,j] = arr2d[i-1,j] + arr2d[i-1,j-1] + arr2d[i, j-1];
            }
        }

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                Console.Write($"{arr2d[i,j]} ");
            }
            Console.WriteLine();
        }

    }
}
