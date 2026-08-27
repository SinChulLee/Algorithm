using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int Y = int.Parse(Console.ReadLine());

        if (Y % 4 == 0)
        {
            if (Y % 100 == 0 && Y % 400 != 0)
                Console.Write("false");
            else
                Console.Write("true");    
        }
        else
        {
            Console.Write("false");
        }
    }
}
