using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int prod = 2;

        for (int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                Console.Write($"{prod} ");
                prod += 2;
                if (prod >= 10)
                    prod = 2;
            }
            Console.WriteLine();
        }
    }
}
