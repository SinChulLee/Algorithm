using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        for(int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if(c >= 'a' && c <= 'z')
                c = (char)(c - 'a' + 'A');

            if(c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                Console.Write(c);
        }
    }
}
