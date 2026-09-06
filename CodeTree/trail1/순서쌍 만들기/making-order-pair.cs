using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for(int i = N; i >= 1; i--)
        {
            for(int j = N; j >= 1; j--)
                Console.Write($"({i},{j}) ");

            Console.WriteLine();
        }
    }
}
