using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        int len = str.Length;
        Console.WriteLine(str);
        for(int i = 0; i < len; i++)
        {
            str = str.Substring(len-1,1) + str.Substring(0, len-1);
            Console.WriteLine(str);
        }
    }
}
