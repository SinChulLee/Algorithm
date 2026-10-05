using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        char a = input[0][0];
        char b = input[1][0];

        int sum = (int)a + (int)b;
        int dv = a > b ? (int)a - (int)b : (int)b - (int)a;
        Console.Write($"{sum} {dv}");
    }
}
