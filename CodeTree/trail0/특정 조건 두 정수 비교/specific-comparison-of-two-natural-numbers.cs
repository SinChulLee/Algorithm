using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        string ans = "";

        if (A < B)
        {
            ans += "1";
        }
        else
        {
            ans += "0";
        }

        if (A == B)
        {
            ans += " 1";
        }
        else
        {
            ans += " 0";
        }

        Console.WriteLine(ans);
    }
}
