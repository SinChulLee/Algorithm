using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        int min = a < b ? a : b;
        min = min < c ? min : c;

        Console.Write(a == min ? 1 : 0);
        Console.Write(" ");
        Console.Write(a == b && b == c ? 1 : 0);
    }
}
