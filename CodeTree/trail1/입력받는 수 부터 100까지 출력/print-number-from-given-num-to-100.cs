using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        Console.Write($"{n}");
        for (int i = n+1; i <= 100; i++)
        {
            Console.Write($" {i}");
        }
    }
}
