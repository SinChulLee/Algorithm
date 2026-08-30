using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        while(true)
        {
            int N = int.Parse(Console.ReadLine());
            if (N < 25)
                Console.WriteLine("Higher");
            else if (N > 25)
                Console.WriteLine("Lower");
            else
            {
                Console.WriteLine("Good");
                break;
            }
        }
    }
}
