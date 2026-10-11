using System;

public class Codetree
{  
    public static void PrintLines(int n)
    {
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("12345^&*()_");
        }
    }

    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        PrintLines(N);
        // Please write your code here.
    }
}
