using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string A = Console.ReadLine();
        string B = Console.ReadLine();

        string a = A+B;
        string b = B+A;

        if(a == b)
            Console.Write("true");
        else
            Console.Write("false");
    }
}
