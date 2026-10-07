using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] >= 'A' && str[i] <= 'Z')
                Console.Write((char)(str[i] - 'A' + 'a'));
            if(str[i] >= 'a' && str[i] <= 'z')
                Console.Write(str[i]);
            if(str[i] >= '0' && str[i] <= '9')
                Console.Write(str[i]);
        }
    }
}
