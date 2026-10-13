using System;

public class Codetree
{  
    public static void PrintMinValue(int a, int b, int c)
    {
        int maxvalue = a;
        if(b < maxvalue)
            maxvalue = b;
        if(c < maxvalue)
            maxvalue = c;
        Console.Write(maxvalue);
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        PrintMinValue(a,b,c);
    }
}
