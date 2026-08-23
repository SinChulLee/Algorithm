using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string ans = "5";

        for(int i = 6; i < 18; i++)
        {
            ans += $" {i}";
        }

        Console.WriteLine(ans);
    }
}
