using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split('-');
        int m = int.Parse(input[0]);
        int d = int.Parse(input[1]);
        int y = int.Parse(input[2]);

        Console.Write($"{y}.{m}.{d}");
    }
}
