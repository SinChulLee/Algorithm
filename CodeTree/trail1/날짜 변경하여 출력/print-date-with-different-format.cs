using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split('.');
        Console.Write($"{input[1]}-{input[2]}-{input[0]}");

    }
}
