using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int ans = 0;

        if (A < B)
        {
            for (int i = A; i <= B; i++)
            {
                if (i % 5 == 0)
                    ans += i;
            }
        }
        else
        {
            for (int i = B; i <= A; i++)
            {
                if (i % 5 == 0)
                    ans += i;
            }
        }

        Console.Write(ans);
    }
}
