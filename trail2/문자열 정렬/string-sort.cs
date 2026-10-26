using System;

public class Codetree
{  
    public static void PrintStr(char[] arr)
    {
        Console.Write(new string(arr));
    }

    public static void Main()
    {
        // Please write your code here.
        string S = Console.ReadLine();
        char[] arr = S.ToCharArray();
        Array.Sort(arr);
        PrintStr(arr);
    }
}
