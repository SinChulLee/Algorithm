using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        char a = input[0][0];
        int b = int.Parse(input[1]);

        Console.Write($"{(int)a} {(char)b}");
    }
}
