using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        str = str.Remove(1,1);
        str = str.Remove(str.Length-2,1);
        Console.Write(str);
    }
}
