using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0 || i % 10 == 5 || (i % 3 == 0 && i % 9 != 0))
                continue;
            Console.Write($"{i} ");
        }
    }
}
