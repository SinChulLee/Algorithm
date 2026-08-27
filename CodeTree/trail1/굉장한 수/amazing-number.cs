using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        if ((N % 2 == 1 && N % 3 == 0) || (N % 2 == 0 && N % 5 == 0))
            Console.Write("true");
        else
            Console.Write("false");
    }
}
