using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int a = int.Parse(Console.ReadLine());

        if (a < 0)
        {
            Console.WriteLine("ice");
        }
        else if(a >= 100)
        {
            Console.WriteLine("vapor");
        }
        else
        {
            Console.WriteLine("water");
        }
    }
}
