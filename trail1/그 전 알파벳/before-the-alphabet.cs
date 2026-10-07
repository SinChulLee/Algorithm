using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        char al = str[0];
        int num = (int)al;
        num -= 1;
        char ans = (char)num;
        if(al == 'a')
            Console.Write('z');
        else
            Console.Write(ans);
    }
}
