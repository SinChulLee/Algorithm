using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < 2 * N + 1; i++)
        {
            for(int j = 0; j < 2 * N + 1; j++)
            {
                if(j % 2 == 1 && i % 2 == 1)
                    Console.Write("  ");
                else
                    Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
