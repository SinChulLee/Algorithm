using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        if (N >= 90)
        {
            Console.WriteLine("A");
        }
        else if (N >= 80)
        {
            Console.WriteLine("B");
        }
        else if (N >= 70)
        {
            Console.WriteLine("C");
        }
        else if (N >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
