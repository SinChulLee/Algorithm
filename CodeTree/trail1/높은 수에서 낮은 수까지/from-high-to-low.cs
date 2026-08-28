using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        if (A > B)
        {
            for (int i = A; i >= B; i--)
            {
                Console.Write($"{i} ");
            }
        }
        else
        {
            for (int i = B; i >= A; i--)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
