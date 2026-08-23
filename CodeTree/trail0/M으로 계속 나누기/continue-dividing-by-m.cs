using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        Console.WriteLine(N);
        while(N != 0)
        {
            N = N/M;
            if (N != 0)
            {
                Console.WriteLine(N);
            }
        }
    }
}
