using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            for(int j = 0; j < 2 * N - 2 - i * 2; j++)
                Console.Write(" ");
            for(int k = 0; k < i + 1; k++)
                Console.Write("@ ");
            Console.WriteLine();
        }

        for (int i = 0; i < N - 1; i++)
        {
            for(int j = 0; j < N - 1 - i; j++)
                Console.Write("@ ");
            Console.WriteLine();
        }
    }
}
