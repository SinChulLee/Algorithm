using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(':');
        int h = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        Console.Write($"{h+1}:{m}");
    }
}
