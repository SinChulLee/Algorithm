using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        Console.WriteLine(A+B);
        Console.WriteLine(A-B);
        Console.WriteLine(A/B);
        Console.WriteLine(A%B);
    }
}
