using System;

public class Codetree
{  
    public static int Sum(int n)
    {  
        if(n < 10)
            return n*n;
        return Sum(n / 10) + (n%10)*(n%10);
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(Sum(N));
    }
}
