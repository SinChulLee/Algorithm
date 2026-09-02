using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        for (int i = N; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        for (int i = 2; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
