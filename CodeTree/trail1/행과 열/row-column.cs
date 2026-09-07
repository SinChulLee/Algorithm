using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        for(int i = 1; i <= A; i++)
        {
            for(int j = 1; j <= B; j++)
            {
                Console.Write($"{i*j} ");
            }
            Console.WriteLine();
        }
    }
}
