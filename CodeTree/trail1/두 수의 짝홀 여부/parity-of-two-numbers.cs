using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        if (a % 2 == 0)
            Console.WriteLine("even");
        else
            Console.WriteLine("odd");

        if (b % 2 == 0)
            Console.WriteLine("even");
        else
            Console.WriteLine("odd");

    }
}
