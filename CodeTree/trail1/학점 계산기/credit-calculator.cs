using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        double[] score = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
        double sum = 0;
        double avg = 0;
        for(int i = 0; i < N; i++)
        {
            sum += score[i];
        }
        avg = sum/N;
        Console.WriteLine($"{avg:F1}");
        if(avg >= 4.0)
            Console.WriteLine("Perfect");
        else if(avg >= 3.0)
            Console.WriteLine("Good");
        else
            Console.WriteLine("Poor");
    }
}
