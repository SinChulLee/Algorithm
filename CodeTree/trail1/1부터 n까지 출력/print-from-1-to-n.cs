using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(1);
        if (N <= 1)
            return;
        for (int i = 2; i <= N; i++)
        {
            Console.Write($" {i}");
        }
    }
}
