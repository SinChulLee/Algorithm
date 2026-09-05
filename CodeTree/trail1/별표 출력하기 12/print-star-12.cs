using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int linelength = N % 2 == 0 ? N : N - 1;

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < 2 * N - 1; j++)
            {
                if (i == 0 && j % 2 == 0)
                {
                    Console.Write("*");
                }
                else if(j % 4 == 2)
                    if(i < j / 2 + 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
