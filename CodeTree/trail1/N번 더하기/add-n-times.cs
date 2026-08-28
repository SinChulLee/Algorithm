using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int N = int.Parse(input[1]);

        for (int i = 1; i <= N; i++)
        {
            A += N;
            Console.WriteLine(A);
        }
    }
}
