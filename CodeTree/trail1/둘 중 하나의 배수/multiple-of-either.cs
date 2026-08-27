using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int A = int.Parse(Console.ReadLine());

        if (A % 3 == 0 || A % 5 == 0)
            Console.Write(1);
        else
            Console.Write(0);
    }
}
