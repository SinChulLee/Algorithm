using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int M = int.Parse(Console.ReadLine());

        if (M >= 3 && M <= 5)
            Console.Write("Spring");
        else if (M >= 6 && M <= 8)
            Console.Write("Summer");
        else if (M >= 9 && M <= 11)
            Console.Write("Fall");
        else
            Console.Write("Winter");
    }
}
