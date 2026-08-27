using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        int ans1;
        int ans2;

        if (A < B)
            ans1 = 1;
        else
            ans1 = 0;

        if (A == B)
            ans2 = 1;
        else
            ans2 = 0;

        Console.Write($"{ans1} {ans2}");
    }
}
