using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = 1;
        int[,] arr2d = new int[N,N];
        for(int i = N-1; i >= 0; i--)
        {
            for(int j = N-1; j >= 0; j--)
            {
                if((N-i-1) % 2 == 1)
                {
                    arr2d[N-j-1,i] = cnt;
                    cnt++;
                }
                else
                {
                    arr2d[j,i] = cnt;
                    cnt++;
                }
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
