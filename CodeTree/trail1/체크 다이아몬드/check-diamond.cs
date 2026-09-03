using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for(int i = 0; i < N; i++)
        {
            for (int j = 0; j < N - i - 1; j++)
                Console.Write(" ");
            for (int k = 0; k < i + 1; k++)
                Console.Write("* ");
            Console.WriteLine();
        }

        for(int i = 1; i < N; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write(" ");
            for (int k = 0; k < N - i; k++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }
}
