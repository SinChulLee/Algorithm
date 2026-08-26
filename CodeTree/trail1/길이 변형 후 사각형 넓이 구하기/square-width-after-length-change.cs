using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        a += 8;
        b *= 3;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(a*b);
    }
}
