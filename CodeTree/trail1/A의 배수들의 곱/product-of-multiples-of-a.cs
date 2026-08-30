using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int ans = 1;

        for (int i = 1; i <= B; i++)
        {
            if (i % A == 0)
                ans *= i;
        }

        Console.Write(ans);
    }
}
