using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input_A = Console.ReadLine().Split(' ');
        string[] input_B = Console.ReadLine().Split(' ');

        int A_math = int.Parse(input_A[0]);
        int A_eng = int.Parse(input_A[1]);

        int B_math = int.Parse(input_B[0]);
        int B_eng = int.Parse(input_B[1]);

        if (A_math > B_math && A_eng > B_eng)
            Console.WriteLine(1);
        else
            Console.WriteLine(0);
    }
}
