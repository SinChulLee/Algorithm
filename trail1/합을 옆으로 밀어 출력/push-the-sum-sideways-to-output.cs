using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int ans = 0;
        for(int i = 0; i < N; i++)
        {
            ans += int.Parse(Console.ReadLine());
        }
        string str = ans.ToString();
        str = str.Substring(1) + str.Substring(0, 1);
        Console.Write(str);
    }
}
