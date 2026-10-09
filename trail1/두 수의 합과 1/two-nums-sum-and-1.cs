using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int num = a+b;
        string str = num.ToString();
        int ans = 0;
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] == '1')
                ans++;
        }
        Console.Write(ans);
    }
}
