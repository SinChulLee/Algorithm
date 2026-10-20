using System;

public class Codetree
{  
    public static void Func1(int n)
    {
        if(n < 1)
            return;
        Func1(n-1);
        Console.Write($"{n} ");
    }

    public static void Func2(int n)
    {
        if(n < 1)
            return;
        Console.Write($"{n} ");
        Func2(n-1);
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Func1(N);
        Console.WriteLine();
        Func2(N);
    }
}
