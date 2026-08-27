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

        if (A_math > B_math)
            Console.WriteLine("A");
        else if (B_math > A_math)
            Console.WriteLine("B");
        else if (A_math == B_math)
        {
            if (A_eng > B_eng)
                Console.WriteLine("A");
            else if (B_eng > A_eng)
                Console.WriteLine("B");
            
        }

        
    }
}
