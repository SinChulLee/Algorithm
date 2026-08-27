using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        if (N >= 3000)
            Console.Write("book");
        else if (N >= 1000)
            Console.Write("mask");
        else if (N >= 500)
            Console.Write("pen");
        else
            Console.Write("no");
    }
}
