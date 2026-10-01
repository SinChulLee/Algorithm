using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        for(int i = str.Length - 1; i >= 0; i--)
        {
            if(i % 2 == 1)
                Console.Write(str[i]);
        }
    }
}
