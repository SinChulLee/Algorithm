using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string s = Console.ReadLine();
        char c = s[0];
        int num = (int)c + 1;
        if(num > 122)
            num = 97;
        Console.Write((char)num);
    }
}
