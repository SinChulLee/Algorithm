using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        char al = Console.ReadLine()[0];
        int cnt= 0;
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] == al)
                cnt++;
        }
        Console.Write(cnt);
    }
}
