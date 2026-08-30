using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = 0;

        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0)
                continue;

            cnt++;
        }

        Console.Write(cnt);
    }
}
