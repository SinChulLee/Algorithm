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
        int cnt = 0;

        for (int i = A; i <= B; i++)
        {
            if (i % 5 == 0 || i % 7 == 0)
            {
                ans += i;
                cnt += 1;
            }
        }
        Console.Write($"{ans} {(double)ans/cnt:F1}");
    }
}
