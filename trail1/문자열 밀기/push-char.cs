using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        str = str.Substring(1, str.Length-1) + str.Substring(0, 1);
        Console.Write(str);
    }
}
