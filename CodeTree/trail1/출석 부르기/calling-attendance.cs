using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
            Console.Write("John");
        else if (n == 2)
            Console.Write("Tom");
        else if (n == 3)
            Console.Write("Paul");
        else
            Console.Write("Vacancy");
    }
}
