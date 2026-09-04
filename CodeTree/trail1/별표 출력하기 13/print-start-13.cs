using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for(int i = 0; i < N * 2; i++)
        {
            if(i % 2 == 0)
            {
                for(int j = N - (i / 2); j > 0; j--)
                {
                    Console.Write("* ");
                }
            }
            else
            {
                for(int j = 0; j < i - (i / 2); j++)
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
}
