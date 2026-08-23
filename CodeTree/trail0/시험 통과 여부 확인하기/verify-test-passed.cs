using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int a = int.Parse(Console.ReadLine());

        if(a >= 80)
        {
            Console.WriteLine("pass");
        }
        else
        {
            Console.WriteLine($"{80-a} more score");
        }

    }
}
