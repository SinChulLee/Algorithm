using System;

public class Codetree
{  
    public static void PrintHello(int n)
    {
        if(n == 0)
            return;
        
        PrintHello(n-1);
        Console.WriteLine("HelloWorld");
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        PrintHello(N);
    }
}
