using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());

        if (n >= 3000)
            Console.Write("book");
        else if (n >= 1000)
            Console.Write("mask");
        else
            Console.Write("no");
    }
}
