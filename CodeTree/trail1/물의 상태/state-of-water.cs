using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
            Console.Write("ice");
        else if (n >= 100)
            Console.Write("vapor");
        else
            Console.Write("water");
    }
}
