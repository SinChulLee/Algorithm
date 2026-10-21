using System;

public class Codetree
{  
    public static int cnt;

    public static int f(int n)
    {
        if(n == 1)
            return cnt;

        cnt++;
        if(n % 2 == 0)
            return f(n/2);
        else
            return f(n/3);
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Console.Write(f(N));
    }
}
