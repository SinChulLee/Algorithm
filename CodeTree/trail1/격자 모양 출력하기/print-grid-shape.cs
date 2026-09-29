using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int[,] arr2d = new int[N,N];

        for(int i = 0; i < M; i++)
        {
            string[] input2 = Console.ReadLine().Split(' ');
            int num1 = int.Parse(input2[0]);
            int num2 = int.Parse(input2[1]);
            arr2d[num1-1, num2-1] = num1*num2;
        }

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
                Console.Write($"{arr2d[i,j]} ");
            Console.WriteLine();
        }
    }
}
