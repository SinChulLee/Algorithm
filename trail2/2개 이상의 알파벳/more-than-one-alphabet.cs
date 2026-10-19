using System;

public class Codetree
{  
    public static bool Judge(string str)
    {
        char c = str[0];
        for(int i = 1; i < str.Length; i++)
        {
            if(c != str[i])
                return true;
        }
        return false;
    }

    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        if(Judge(str))
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}
