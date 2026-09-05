using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                if (i == 0 || j == 0 || i == N - 1 || j == N - 1)
                    Console.Write("* ");
                else if(j >= i && j < N)
                    Console.Write("  ");
                else
                    Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
