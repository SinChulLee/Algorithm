using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');

        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);

        int median;

        if ((A >= B && A <= C) || (A <= B && A >= C))
            median = A;
        else if ((B >= A && B <= C) || (B <= A && B >= C))
            median = B;
        else
            median = C;

        Console.Write(median);
    }
}
