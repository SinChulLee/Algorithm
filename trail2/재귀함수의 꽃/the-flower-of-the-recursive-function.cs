using System;

public class Codetree
{  
    public static void f(int n)
    {
        if(n < 1)
            return;
        Console.Write($"{n} ");
        f(n-1);
        Console.Write($"{n} ");
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        f(N);
    }
}
