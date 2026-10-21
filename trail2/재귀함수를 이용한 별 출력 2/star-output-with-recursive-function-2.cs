using System;

public class Codetree
{
    public static void f(int n)
    {
        if(n < 1)
            return;
        for(int i = 0; i < n; i++)
            Console.Write("* ");
        Console.WriteLine();
        f(n-1);
        for(int i = 0; i < n; i++)
            Console.Write("* ");
        Console.WriteLine();
    }

    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        f(n);
    }
}