using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string a = Console.ReadLine();
        string ans = "";

        for(int i = 0; i < 8; i++)
        {
            ans += a;
        }

        Console.WriteLine(ans);
    }
}
