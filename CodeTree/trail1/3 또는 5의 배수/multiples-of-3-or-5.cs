using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int A = int.Parse(Console.ReadLine());

        if (A % 3 == 0)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");

        if (A % 5 == 0)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
