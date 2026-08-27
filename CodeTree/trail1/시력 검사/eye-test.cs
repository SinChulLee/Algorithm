using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a >= 1.0 && b >= 1.0)
            Console.WriteLine("High");
        else if (a >= 0.5 && b >= 0.5)
            Console.WriteLine("Middle");
        else
            Console.WriteLine("Low");
    }
}
