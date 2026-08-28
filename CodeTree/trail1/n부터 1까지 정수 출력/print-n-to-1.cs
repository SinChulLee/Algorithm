using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());

        while (n >= 1)
        {
            Console.Write($"{n} ");
            n -= 1;
        }
    }
}
