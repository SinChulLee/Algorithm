using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int A = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');

        int B = int.Parse(input[0]);
        int C = int.Parse(input[1]);
        int D = int.Parse(input[2]);
        int E = int.Parse(input[3]);

        if (A > B)
            Console.WriteLine(1);
        else
            Console.WriteLine(0);

        if (A > C)
            Console.WriteLine(1);
        else
            Console.WriteLine(0);

        if (A > D)
            Console.WriteLine(1);
        else
            Console.WriteLine(0);

        if (A > E)
            Console.WriteLine(1);
        else
            Console.WriteLine(0);
    }
}
