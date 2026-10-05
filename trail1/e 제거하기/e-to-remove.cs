using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        int index = str.IndexOf("e");
        str = str.Remove(index, 1);
        Console.Write(str);
    }
}
