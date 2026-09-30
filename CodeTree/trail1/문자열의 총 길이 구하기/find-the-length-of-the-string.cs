using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int ans = 0;

        for(int i = 0; i < input.Length; i++)
        {
            ans += input[i].Length;
        }
        Console.Write(ans);
    }
}
