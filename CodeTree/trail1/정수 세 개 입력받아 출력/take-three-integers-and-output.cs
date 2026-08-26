using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int c = int.Parse(Console.ReadLine());
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        Console.Write($"{a} {b} {c}");

    }
}
