using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string n = Console.ReadLine();
        int ans = 0;
        for(int i = 0; i < n.Length; i++)
        {
            ans += n[i] - '0';
        }
        Console.Write(ans);
    }
}
