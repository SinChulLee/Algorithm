using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[,] arr2d = new int[N,N];
        int cnt = 1;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                arr2d[j,i] = cnt;
                cnt++;
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
