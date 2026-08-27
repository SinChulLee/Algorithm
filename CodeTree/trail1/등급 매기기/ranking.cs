using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        if (N >= 90)
            Console.Write("A");
        else if (N >= 80)
            Console.Write("B");
        else if (N >= 70)
            Console.Write("C");
        else if (N >= 60)
            Console.Write("D");
        else
            Console.Write("F");
    }
}
