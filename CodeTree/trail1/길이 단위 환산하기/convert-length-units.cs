using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        double ft = double.Parse(Console.ReadLine());
        Console.Write($"{30.48*ft:F1}");
    }
}
