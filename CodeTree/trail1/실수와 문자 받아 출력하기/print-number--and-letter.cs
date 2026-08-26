using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        char c = Console.ReadLine()[0];
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine(c);
        Console.WriteLine($"{a:F2}");
        Console.WriteLine($"{b:F2}");
    }
}
