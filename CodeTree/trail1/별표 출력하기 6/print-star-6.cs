using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            for(int k = 0; k < 2 * i; k++)
            {
                Console.Write(" ");
            }

            for(int j = 0; j < 2 * N - 2 * i - 1; j++)
            {
                Console.Write("* ");
            }
            
            Console.WriteLine();
        }

        // 아래 삼각형
        for (int i = 1; i < N; i++)
        {
            for(int k = 0; k < 2 * N - 2 * i - 2; k++)
            {
                Console.Write(" ");
            }

            for(int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("* ");
            }
            
            Console.WriteLine();
        }
    }
}
