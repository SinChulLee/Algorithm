using System;

public class Codetree
{  
    public static void PrintStar(int n)
    {
        if(n < 1)
            return;
        PrintStar(n-1);
        for(int i = 0; i < n; i++)
            Console.Write("*");
        Console.WriteLine();
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        PrintStar(N);
    }
}
