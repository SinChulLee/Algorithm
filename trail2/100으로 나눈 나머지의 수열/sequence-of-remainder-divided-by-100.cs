using System;

public class Codetree
{  
    public static int[] arr = {2, 4};

    public static int F(int N)
    {
        if(N == 1)
            return 2;
        if(N == 2)
            return 4;

        return F(N-2) * F(N-1) % 100;
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(F(N));
    }
}
