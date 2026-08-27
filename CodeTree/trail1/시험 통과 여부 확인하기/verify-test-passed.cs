using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        if (N >= 80)
            Console.Write("pass");
        else
            Console.Write($"{80-N} more score");
    }
}
