using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int h = int.Parse(input[0]);
        int w = int.Parse(input[1]);
        int b = (10000*w)/(h*h);
        Console.WriteLine(b);
        if (b >= 25)
        {
            Console.WriteLine("Obesity");
        }
    }
}
