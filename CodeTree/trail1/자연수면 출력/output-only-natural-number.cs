using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        if (A > 0)
        {
            for (int i = 1; i <= B; i++)
            {
                Console.Write(A);
            }
        }
        else
        {
            Console.Write(0);
        }
    }
}
