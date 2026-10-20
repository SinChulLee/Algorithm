using System;

public class Codetree
{  
    public static int RetrunAns(int M, int[] arr)
    {
        int Ans = arr[M-1];
        while(M != 1)
        {
            if(M % 2 == 1)
                M -= 1;
            else
                M /= 2;
            Ans += arr[M-1];
        }
        return Ans;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.Write(RetrunAns(M,arr));
    }
}
