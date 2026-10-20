using System;

public class Codetree
{  
    public static int[] A;

    public static void PrintSum(int M)
    {
        for(int i = 0; i < M; i++)
        {
            int sum = 0;
            string[] input = Console.ReadLine().Split();
            int a1 = int.Parse(input[0]);
            int a2 = int.Parse(input[1]);
            for(int j = a1-1; j < a2; j++)
                sum += A[j];
            Console.WriteLine(sum);
        }
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        PrintSum(M);
    }
}
