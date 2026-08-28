using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        char C = char.Parse(input[0]);
        int N = int.Parse(input[1]);

        if (C == 'A')
        {
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"{i} ");
            }
        }
        else if (C == 'D')
        {
            for (int i = N; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
