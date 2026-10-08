using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] >= 'a' && str[i] <= 'z')
                Console.Write((char)(str[i] - 'a' + 'A'));
            if(str[i] >= 'A' && str[i] <= 'Z')
                Console.Write((char)(str[i] - 'A' + 'a'));
        }
    }
}
