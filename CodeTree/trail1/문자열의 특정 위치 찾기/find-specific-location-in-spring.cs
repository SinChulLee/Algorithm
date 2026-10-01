using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        string str = input[0];
        char a = input[1][0];

        int ans = str.IndexOf(a);
        if(ans != -1)
            Console.Write(ans);
        else
            Console.Write("No");
    }
}
