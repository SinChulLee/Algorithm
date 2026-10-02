using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        string str1 = input[0];
        string str2 = input[1];

        string ans = str1.Substring(0, 2) + str2.Substring(2);
        Console.Write(ans);
    }
}
