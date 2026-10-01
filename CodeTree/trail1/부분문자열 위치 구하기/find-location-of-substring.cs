using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        string tar = Console.ReadLine();
        int ans = -1;
        ans = str.IndexOf(tar);
        Console.Write(ans);
    }
}
