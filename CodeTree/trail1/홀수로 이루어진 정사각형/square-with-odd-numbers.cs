using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for(int i = 11; i <= 11 + 2 * (N - 1); i++)
        {
            if (i % 2 == 1)
            {
                for(int j = 0; j <= 1 + 2 * (N - 1); j++)
                {
                    if(j % 2 == 0)
                        Console.Write($"{i + j} ");
                }
            }
            else
                Console.WriteLine();
        }
    }
}
