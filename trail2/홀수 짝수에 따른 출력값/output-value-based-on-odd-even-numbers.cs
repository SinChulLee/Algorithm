using System;

public class Codetree
{  
    public static int F1(int n)
    {
        if(n == 1)
            return 1;
        return F1(n-2) + n;
    }

    public static int F2(int n)
    {
        if(n == 2)
            return 2;
        return F2(n-2) + n;
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        if(N % 2 == 1)
            Console.Write(F1(N));
        else
            Console.Write(F2(N));
    }
}
