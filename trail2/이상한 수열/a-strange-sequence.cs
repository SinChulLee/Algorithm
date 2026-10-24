using System;

public class Codetree
{  
    public static int F(int n)
    {
        if(n == 1)
            return 1;
        if(n == 2)
            return 2;

        return F(n/3) + F(n-1);
    }
    
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(F(N));
    }
}
