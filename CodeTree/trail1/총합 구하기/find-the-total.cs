using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int sum = 0;

        for (int i = A; i <= B; i++)
        {
            if (i % 6 == 0 && i % 8 != 0)
                sum += i;
        }
        
        Console.Write(sum);
    }
}
