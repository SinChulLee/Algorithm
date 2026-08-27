using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input_A = Console.ReadLine().Split(' ');
        string[] input_B = Console.ReadLine().Split(' ');
        string[] input_C = Console.ReadLine().Split(' ');

        char ag = char.Parse(input_A[0]);
        int a = int.Parse(input_A[1]);

        char bg = char.Parse(input_B[0]);
        int b = int.Parse(input_B[1]);

        char cg = char.Parse(input_C[0]);
        int c = int.Parse(input_C[1]);

        int count_A = 0;

        if ((ag == 'Y' && a >= 37))
            count_A += 1;
        if ((bg == 'Y' && b >= 37))
            count_A += 1;
        if ((cg == 'Y' && c >= 37))
            count_A += 1;

        if (count_A >= 2)
            Console.Write("E");
        else
            Console.Write("N");
    }
}
