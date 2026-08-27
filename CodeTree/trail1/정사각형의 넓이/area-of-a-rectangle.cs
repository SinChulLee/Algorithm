using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(N*N);
        if (N < 5)
        {
            Console.Write("tiny");
        }
    }
}
