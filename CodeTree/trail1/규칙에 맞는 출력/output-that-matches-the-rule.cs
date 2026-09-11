using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for(int i = N; i >= 1; i--)
        {
            for(int j = 1; j <= N; j++)
            {
                if(j >= i)
                    Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
