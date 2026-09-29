using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();

        for(int i = 0; i < str1.Length; i++)
        {
            if(str1[i] != ' ')
                Console.Write(str1[i]);
        }

        for(int i = 0; i < str2.Length; i++)
        {
            if(str2[i] != ' ')
                Console.Write(str2[i]);
        }
    }
}
