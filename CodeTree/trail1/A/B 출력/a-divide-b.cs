using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        int ans = (A/B);
        Console.Write($"{ans}.");
        A = A % B;
        
        for (int i = 1; i < 21; i++)
        {
            A *= 10;
            Console.Write(A / B);
            A = A % B;
        }
    }
}
