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

        Console.WriteLine(a+b+c);
        Console.WriteLine((a+b+c)/3);
        Console.WriteLine(a+b+c - (a+b+c)/3);
    }
}
