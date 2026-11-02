using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string digit = Console.ReadLine();
        int ans = 0;
        for(int i = 0; i < digit.Length; i++)
        {
            int num = digit[i] - '0';
            ans = ans * 2 + num;
        }
        Console.Write(ans);
    }
}
