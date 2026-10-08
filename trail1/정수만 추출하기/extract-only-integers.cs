using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        string A = input[0];
        string B = input[1];
        string result_A = "";
        string result_B = "";
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] >= '0' && A[i] <= '9')
                result_A += A[i];
            else
                break;
        }

        for(int j = 0; j < B.Length; j++)
        {
            if(B[j] >= '0' && B[j] <= '9')
                result_B += B[j];
            else
                break;
        }
        int resultA = int.Parse(result_A);
        int resultB = int.Parse(result_B);
        Console.Write(resultA+resultB);
    }
}
