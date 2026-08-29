using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int ans = 0;
        for (int i = N; i <= 100; i++)
        {
            ans += i;
        }
        Console.Write(ans);
    }
}
