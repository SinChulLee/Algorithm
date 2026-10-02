using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        char[] arr = str.ToCharArray();
        arr[1] = 'a';
        arr[arr.Length-2] = 'a';
        str = new string(arr);
        Console.Write(str);

    }
}
