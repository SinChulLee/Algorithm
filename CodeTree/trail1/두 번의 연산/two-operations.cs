using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int A = int.Parse(Console.ReadLine());

        if (A % 2 == 1)
            A += 3;

        if (A % 3 == 0)
            A /= 3;

        Console.Write(A);
    }
}
