using System;

public class Codetree
{  
    public static int Fact(int n)
    {
        if(n == 1)
            return 1;
        
        return Fact(n-1) * n;
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(Fact(N));
    }
}
