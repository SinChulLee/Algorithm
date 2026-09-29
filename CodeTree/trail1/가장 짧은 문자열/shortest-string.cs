using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        string str3 = Console.ReadLine();

        int min = str1.Length;
        if(str2.Length < min)
            min = str2.Length;
        if(str3.Length < min)
            min = str3.Length;

        int max = str1.Length;
        if(str2.Length > max)
            max = str2.Length;
        if(str3.Length > max)
            max = str3.Length;
        
        Console.Write(max-min);
    }
}
