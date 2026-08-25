using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int a = 5;
        int b = 6;
        int c = 7;

        int ta = a;
        int tb = b;
        int tc = c;
        b = ta; c = tb; a = tc;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
