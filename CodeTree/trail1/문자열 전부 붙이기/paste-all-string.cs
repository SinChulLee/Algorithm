using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        string ans = "";
        for(int i = 0; i < N; i++)
        {
            ans += Console.ReadLine();
        }
        Console.Write(ans);
    }
}
