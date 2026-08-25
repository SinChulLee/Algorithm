using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int a = 1;
        int b = 2;
        int c = 3;

        int sum = a+b+c;
        a = b = c= sum;

        Console.Write($"{a} {b} {c}");
    }
}
