using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);

        if (B > A && B < C)
            Console.Write(1);
        else
            Console.Write(0);
    }
}
