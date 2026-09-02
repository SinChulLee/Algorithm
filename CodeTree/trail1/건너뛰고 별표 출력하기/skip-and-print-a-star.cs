using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write('*');
            Console.WriteLine();
            Console.WriteLine();
        }

        for (int i = N-2; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
                Console.Write('*');
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
