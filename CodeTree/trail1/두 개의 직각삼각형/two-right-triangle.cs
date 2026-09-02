using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N - i; j++)
            {
                Console.Write("*");
            }

            for (int k = 0; k < i * 2; k++)
            {
                Console.Write(" ");
            }

            for (int h = 0; h < N - i; h++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
