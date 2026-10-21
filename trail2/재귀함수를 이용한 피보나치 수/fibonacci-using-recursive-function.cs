using System;

public class Codetree
{  
    public static int F(int n)
    {
        if(n == 1 || n == 2)
            return 1;
        return F(n-1) + F(n-2);
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(F(N));
    }
}
