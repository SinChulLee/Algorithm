using System;

public class Codetree
{  
    public static int F(int n)
    {
        if(n == 1)
            return 0;
        
        if(n % 2 == 0)
            n /= 2;
        else
            n = n * 3 + 1;
        return F(n) + 1;
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(F(N));
    }
}
