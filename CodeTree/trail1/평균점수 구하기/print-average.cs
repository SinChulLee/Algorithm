using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        double sum = 0;
        for(int i = 0; i < 8; i++)
        {
            double score = double.Parse(input[i]);
            sum += score;
        }
        Console.Write($"{(sum/8):F1}");
    }
}
