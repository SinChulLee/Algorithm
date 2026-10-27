using System;

public class Codetree
{  
    public static void F(int N, int[] arr)
    {
        for(int i = 0; i < N; i++)
            if(i % 2 == 0)
            {
                Array.Sort(arr, 0, i+1);
                Console.Write($"{arr[i/2]} ");
            }
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        F(N,arr);
    }
}
