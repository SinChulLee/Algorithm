using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input_A = Console.ReadLine().Split(' ');
        string[] input_B = Console.ReadLine().Split(' ');

        int age_A = int.Parse(input_A[0]);
        char gender_A = char.Parse(input_A[1]);

        int age_B = int.Parse(input_B[0]);
        char gender_B = char.Parse(input_B[1]);

        if ((age_A >= 19 && gender_A == 'M') || (age_B >= 19 && gender_B == 'M'))
            Console.Write(1);
        else
            Console.Write(0);
    }
}
