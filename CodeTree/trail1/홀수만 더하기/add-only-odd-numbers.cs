using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int ans = 0;
        for (int i = 1; i <= N; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 1 && num % 3 == 0)
                ans += num;
        }
        Console.Write(ans);
    }
}
