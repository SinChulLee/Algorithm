using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        char a = Console.ReadLine()[0];

        if (a == 'S')
            Console.Write("Superior");
        else if (a == 'A')
            Console.Write("Excellent");
        else if (a == 'B')
            Console.Write("Good");
        else if (a == 'C')
            Console.Write("Usually");
        else if (a == 'D')
            Console.Write("Effort");
        else
            Console.Write("Failure");
    }
}
