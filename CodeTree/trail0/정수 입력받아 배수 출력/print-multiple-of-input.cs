using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        string ans = $"";

        for(int i = 1; i < 6; i ++)
        {
            if(i > 1)
            {
                ans += $" {N*i}";    
            }
            else
            {
                ans += $"{N*i}";
            }
            
        }

        Console.WriteLine(ans);
    }
}
