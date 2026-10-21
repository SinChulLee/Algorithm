using System;

public class Codetree
{  
    public static int Sum(int n)
    {
        if(n < 1)
            return 0;
        return Sum(n-1) + n;
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(Sum(N));
    }
}
