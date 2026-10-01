using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        int cnt1 = 0;
        int cnt2 = 0;

        for(int i = 0; i < str.Length-1; i++)
        {
            if(str[i] == 'e' && str[i+1] == 'e')
                cnt1++;
            if(str[i] == 'e' && str[i+1] == 'b')
                cnt2++;
        }

        Console.Write($"{cnt1} {cnt2}");
    }
}
