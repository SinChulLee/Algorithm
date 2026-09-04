using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < 2 * N; i++)
        {
            if(i % 2 == 0)
            {
                for(int j = 0; j < 1 + (i / 2); j++)
                {
                    Console.Write("* ");
                }
            }
            else
            {
                for(int j = 0; j < N - (i - 1) / 2; j++)
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
}
